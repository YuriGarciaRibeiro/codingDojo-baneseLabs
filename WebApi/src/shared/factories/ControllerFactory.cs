using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using WebApi.shared.controller;

namespace WebApi.shared.factories;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class GenericRestControllerNameConvention : Attribute, IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        if (!controller.ControllerType.IsGenericType || controller.ControllerType.GetGenericTypeDefinition() != typeof(GenericRestController<,>))
        {
            return;
        }
        var entityType =  controller.ControllerType.GenericTypeArguments[0];
        controller.ControllerName = entityType.Name;
        controller.RouteValues["Controller"] = entityType.Name;
    }
}