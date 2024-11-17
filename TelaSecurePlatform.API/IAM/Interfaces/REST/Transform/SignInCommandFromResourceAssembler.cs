using TelaSecurePlatform.API.IAM.Domain.Model.Commands;
using TelaSecurePlatform.API.IAM.Interfaces.REST.Resources;

namespace TelaSecurePlatform.API.IAM.Interfaces.REST.Transform;

/// <summary>
/// Assembler for <see cref="SignInCommand"/> from <see cref="SignInResource"/> 
/// </summary>
public static class SignInCommandFromResourceAssembler
{
    /// <summary>
    /// Assembles <see cref="SignInCommand"/> from <see cref="SignInResource"/> 
    /// </summary>
    /// <param name="resource">
    /// <see cref="SignInResource"/> Sign in resource
    /// </param>
    /// <returns>
    /// <see cref="SignInCommand"/> Sign in command     
    /// </returns>
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.UserName, resource.Password);
    }
}