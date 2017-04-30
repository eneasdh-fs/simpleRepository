using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using web.Core.Base;
using web.Core.Student;

using connection;
using System;

namespace web
{
  public static class Bootstrapper
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
        
      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }


    /**
     * Registro de las Dependencias = Abstracci�n => objeto concreto
     * 
     * */
    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<RepositoryContract<student>, StudentRepository>();   
    }


  }
}