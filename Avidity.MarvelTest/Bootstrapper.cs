using System;
using System.Web.Mvc;
using Avidity.MarvelTest.Domain.Characters;
using Avidity.MarvelTest.Domain.Stories;
using Avidity.MarvelTest.Infrastructure.System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace Avidity.MarvelTest
{
    public class Bootstrapper
    {
       public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            //This is the important line to edit  
            container.RegisterType<ICharacterSystem, CharacterSystem>();
            container.RegisterType<IComicsSystem, ComicsSystem>();
            container.RegisterType<IStorySystem, StorySystem>();


            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

