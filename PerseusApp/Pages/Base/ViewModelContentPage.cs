using Perseus.App.ViewModels.Base;

namespace Perseus.App.Pages.Base
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
