using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Plugin.Sidebar;
using Sample.Core.ViewModels;

namespace Sample.IosApp.Views
{
    [MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true, MvxSplitViewBehaviour.Detail)]
    public partial class InputFieldsFormView : MvxViewController<InputFieldsFormViewModel>
    {
        public InputFieldsFormView() : base("InputFieldsFormView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<InputFieldsFormView, InputFieldsFormViewModel>();

            set.Bind(FormView).For(v => v.Form).To(vm => vm.Form);
            
            set.Apply();
        }
    }
}

