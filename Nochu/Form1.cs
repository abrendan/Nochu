using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace Nochu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private async void InitializeBrowser()
        {
            // Initialize first tab
            await AddNewTab();
        }

        private async System.Threading.Tasks.Task AddNewTab(string url = "https://search.nochu.ch/")
        {
            TabPage tabPage = new TabPage("New Tab");
            WebView2 webView = new WebView2
            {
                Dock = DockStyle.Fill
            };
            tabPage.Controls.Add(webView);
            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;

            webView.Source = new Uri(url);
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2InitializationCompleted += (s, e) =>
            {
                webView.CoreWebView2.NewWindowRequested += (sender, args) =>
                {
                    args.Handled = true;
                    AddNewTab(args.Uri.ToString());
                };
                UpdateNavigationControls(webView);
            };
        }

        private WebView2 GetCurrentWebView()
        {
            if (tabControl1.SelectedTab?.Controls[0] is WebView2)
            {
                return (WebView2)tabControl1.SelectedTab.Controls[0];
            }
            return null;
        }

        private void UpdateNavigationControls(WebView2 webView)
        {
            btnBack.Enabled = webView.CanGoBack;
            btnForward.Enabled = webView.CanGoForward;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateToURL(txtAddressBar.Text);
        }

        private void NavigateToURL(string url)
        {
            var webView = GetCurrentWebView();
            if (webView != null && !string.IsNullOrWhiteSpace(url))
            {
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "https://search.nochu.ch/search?query=" + url;
                }
                webView.Source = new Uri(url);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var webView = GetCurrentWebView();
            if (webView != null && webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            var webView = GetCurrentWebView();
            if (webView != null && webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var webView = GetCurrentWebView();
            if (webView != null)
            {
                webView.Source = new Uri("https://search.nochu.ch/");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var webView = GetCurrentWebView();
            if (webView != null)
            {
                webView.Reload();
            }
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }
    }
}