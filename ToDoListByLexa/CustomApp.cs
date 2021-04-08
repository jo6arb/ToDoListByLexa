using MvvmCross.ViewModels;

namespace ToDoListByLexa
{
    internal class CustomApp : MvxApplication 
    {
        public override void Initialize()
        {
            RegisterCustomAppStart<AppStart>();
        }
    }
}