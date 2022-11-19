**ASP.NET Core DI container**

ASP.NET Core uses dependency injection throughout the core of the framework. Consequently, the framework includes a simple DI container that provides the minimum capabilities required by the framework itself. There are also many third-party .NET DI libraries that provide many more capabilities and features. for example, like: AutoFac – Ninject - Windsor

**Introduction to Scrutor**

Scrutor is an open-source library that add assembly scanning capabilities to the ASP.NET Core DI container. Scrutor is not a dependency injection (DI) container itself, instead it adds additional capabilities to the built-in container.

**Assembly scanning with Scrutor**

The Scrutor API consists of two extension methods on IServiceCollection, **Scan and Decorate**. The Scan method takes a single argument: a configuration action in which you define four things:

**- A selector:** which implementations (concrete classes) to register.

**- A registration strategy:**  how to handle duplicate services or implementations.

**- The services:** which services (i.e., interfaces) each implementation should be registered as.

**- The lifetime:**  what lifetime to use for the registrations.

**Look at this example:**
```
public interface IService { }
public class Service1 : IService { }
public class Service2 : IService { }
public class Service : IService { }
```
*if we use scan method:*
```
services.Scan(scan => scan     
  .FromCallingAssembly() // 1. Find the concrete classes
    .AddClasses()        //    to register
      .UsingRegistrationStrategy(RegistrationStrategy.Skip) // 2. Define how to handle duplicates
      .AsSelf()    // 2. Specify which services they are registered as
      .WithTransientLifetime()); // 3. Set the lifetime for the services
```
*but with using the built in DI-container we have:*
```
services.AddTransient<Service1>();
services.AddTransient<Service2>();
services.AddTransient<Service>();
services.AddTransient<Foo>();
```

