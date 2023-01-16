using Perseus.App.ViewModels;

namespace Perseus.App.Pages
{
    /// <summary>
    /// Base class for content pages that use a ViewModel to display data
    /// </summary>
    public abstract class ViewModelContentPage : BaseContentPage
    {
        /// <summary>
        /// Initializes the content page using the specified <paramref name="viewModel"/>   
        /// </summary>
        protected ViewModelContentPage(BaseViewModel viewModel) : base()
        {
            BindingContext = viewModel;
        }
    }
}   
