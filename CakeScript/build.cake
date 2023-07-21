#reference "../ExampleAddin/bin/Debug/net7.0/ExampleAddin.dll"

var target = Argument("target", "Default");

Task("Default").Does(() =>
{
    HelloWorld("Test");
});

RunTarget(target);
