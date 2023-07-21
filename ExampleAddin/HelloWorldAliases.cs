using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

namespace ExampleAddin;

[CakeAliasCategory("Example")]
public static class HelloWorldAliases
{
    [CakeMethodAlias]
    public static void HelloWorld(this ICakeContext context, string? parameter)
    {
        
    }
}
