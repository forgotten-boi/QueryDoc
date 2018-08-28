using Abp.Application.Navigation;
using Abp.Localization;

namespace CBT.OnlineTutor.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class OnlineTutorNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                //.AddItem(
                //    new MenuItemDefinition(
                //        PageNames.Home,
                //        L("HomePage"),
                //        url: "",
                //        icon: "fa fa-home"
                //        )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.About,
                //        L("About"),
                //        url: "Home/About",
                //        icon: "fa fa-info"
                //        )
                //)
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.ProgramList,
                        L("ProgramList"),
                        url: "EClass",
                        icon: "fa fa-tasks"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.CategoryList,
                        L("CategoryList"),
                        url: "EClass\\CategoryList",
                        icon: "fa fa-tasks"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.CBTContent,
                        L("CBTContent"),
                        url: "EClass\\CBTContentList",
                        icon: "fa fa-tasks"
                    )
                    //.AddItem(
                    //    new MenuItemDefinition(
                    //        PageNames.CBTContentList,
                    //        L("CBTContentList"),
                    //        url: "EClass\\CBTContentList",
                    //        icon: "fa fa-tasks"
                    //    )
                    //).AddItem(
                    //    new MenuItemDefinition(
                    //        PageNames.DESIGNCONTENT,
                    //        L("DESIGNCONTENT"),
                    //        url: "EClass\\CreateCBTContent",
                    //        icon: "fa fa-tasks"
                    //    )
                    //)
                    ).AddItem(
                        new MenuItemDefinition(
                            PageNames.PREVIEWCONTENT,
                            L("PREVIEWCONTENT"),
                            url: "Preview",
                            icon: "fa fa-tasks"
                        )
                    );
                //.AddItem(
                //    new MenuItemDefinition(
                //        PageNames.MULTIPLETEXBOX,
                //        L("MULTIPLETEXBOX"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.MULTIPLECHOICE,
                //        L("MULTIPLECHOICE"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.DROPDOWN,
                //        L("DROPDOWN"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.VIDEO,
                //        L("VIDEO"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.AUDIO,
                //        L("AUDIO"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.DOCUMENT,
                //        L("DOCUMENT"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //).AddItem(
                //    new MenuItemDefinition(
                //        PageNames.ANIMATION,
                //        L("ANIMATION"),
                //        url: "EClass\\CBTContentList",
                //        icon: "fa fa-tasks"
                //    )
                //)
               // );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, OnlineTutorConsts.LocalizationSourceName);
        }
    }
}
