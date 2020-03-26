using System;
using System.Reflection;

namespace Dotnet.Reflection.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order()
            {
                Id = 1,
                Client = "Teste",
                Active = true
            };

            PrintReflectionOption(order.GetType());
            
            var customer = Activator.CreateInstance<Customer>();
            PrintReflectionOption(customer.GetType());
                       
            customer = (Customer)Activator.CreateInstance(typeof(Customer), "fulano");
            PrintReflectionOption(customer.GetType());

            var method = order.GetType().GetMethod("PrintNow");
            method.Invoke(order, null);

            foreach(var type in Assembly.GetExecutingAssembly().GetTypes())
                Console.WriteLine($"assembly type in this program: {type.Name}");
        }

        private static void PrintReflectionOption(Type type)
        {
            Console.WriteLine($"-> BaseType: {type.BaseType}");
            Console.WriteLine($"-> Name: {type.Name}");
            Console.WriteLine($"-> Assembly.Location: {type.Assembly.Location}");
            Console.WriteLine($"-> Assembly.CodeBase: {type.Assembly.CodeBase}");
            Console.WriteLine($"-> Assembly.FullName: {type.Assembly.FullName}");
            Console.WriteLine($"-> Assembly.GlobalAssemblyCache: {type.Assembly.GlobalAssemblyCache}");
            Console.WriteLine($"-> Assembly.ImageRuntimeVersion: {type.Assembly.ImageRuntimeVersion}");
            Console.WriteLine($"-> Assembly.HostContext: {type.Assembly.HostContext}");
            Console.WriteLine($"-> Assembly.IsCollectible: {type.Assembly.IsCollectible}");
            Console.WriteLine($"-> Assembly.IsFullyTrusted: {type.Assembly.IsFullyTrusted}");
            Console.WriteLine($"-> Assembly.IsDynamic: {type.Assembly.IsDynamic}");
            Console.WriteLine($"-> Assembly.ReflectionOnly: {type.Assembly.ReflectionOnly}");
            Console.WriteLine($"-> Assembly.SecurityRuleSet: {type.Assembly.SecurityRuleSet}");
            Console.WriteLine($"-> AssemblyQualifiedName: {type.AssemblyQualifiedName}");
            Console.WriteLine($"-> FullName: {type.FullName}");
            Console.WriteLine($"-> MemberType: {type.MemberType}");
            Console.WriteLine($"-> ContainsGenericParameters: {type.ContainsGenericParameters}");
            Console.WriteLine($"-> Namespace: {type.Namespace}");
            Console.WriteLine($"-> IsByRef: {type.IsByRef}");
            Console.WriteLine($"-> IsAutoClass: {type.IsAutoClass}");
            Console.WriteLine($"-> IsAbstract: {type.IsAbstract}");
            Console.WriteLine($"-> IsSealed: {type.IsSealed}");
            Console.WriteLine($"-> IsAnsiClass: {type.IsAnsiClass}");
            Console.WriteLine($"-> GUID: {type.GUID}");
            Console.WriteLine($"-> IsClass: {type.IsClass}");
            Console.WriteLine($"-> IsCollectible: {type.IsCollectible}");
            Console.WriteLine($"-> IsCOMObject: {type.IsCOMObject}");
            Console.WriteLine($"-> IsConstructedGenericType: {type.IsConstructedGenericType}");
            Console.WriteLine($"-> IsContextful: {type.IsContextful}");
            Console.WriteLine($"-> IsEnum: {type.IsEnum}");
            Console.WriteLine($"-> IsExplicitLayout: {type.IsExplicitLayout}");
            Console.WriteLine($"-> IsGenericMethodParameter: {type.IsGenericMethodParameter}");
            Console.WriteLine($"-> IsGenericParameter: {type.IsGenericParameter}");
            Console.WriteLine($"-> IsGenericType: {type.IsGenericType}");
            Console.WriteLine($"-> IsImport: {type.IsImport}");
            Console.WriteLine($"-> IsNested: {type.IsNested}");
            Console.WriteLine("Constructor methods");
            foreach (var ctor in type.GetConstructors())
            {
                Console.WriteLine($"-> IsPublic: {ctor.IsPublic}");
                Console.WriteLine($"-> IsStatic: {ctor.IsStatic}");
                Console.WriteLine($"-> IsPrivate: {ctor.IsPrivate}");
                Console.WriteLine($"-> ContainsGenericParameters: {ctor.ContainsGenericParameters}");
                Console.WriteLine($"-> IsAbstract: {ctor.IsAbstract}");
                Console.WriteLine($"-> IsAssembly: {ctor.IsAssembly}");
                Console.WriteLine($"-> IsCollectible: {ctor.IsCollectible}");
                Console.WriteLine($"-> IsConstructedGenericMethod: {ctor.IsConstructedGenericMethod}");
                Console.WriteLine($"-> IsConstructor: {ctor.IsConstructor}");
                Console.WriteLine($"-> IsFamily: {ctor.IsFamily}");
                Console.WriteLine($"-> IsFamilyAndAssembly: {ctor.IsFamilyAndAssembly}");
                Console.WriteLine($"-> IsFamilyOrAssembly: {ctor.IsFamilyOrAssembly}");
                Console.WriteLine($"-> IsFinal: {ctor.IsFinal}");
                Console.WriteLine($"-> IsVirtual: {ctor.IsVirtual}");
                foreach (var parameter in ctor.GetParameters())
                {
                    Console.WriteLine($"-> ParameterType.Name: {parameter.ParameterType.Name}");
                    Console.WriteLine($"-> Name: {parameter.Name}");
                    Console.WriteLine($"-> Member.Name : {parameter.Member.Name}");
                    Console.WriteLine($"-> DefaultValue : {parameter.DefaultValue}");
                    Console.WriteLine($"-> HasDefaultValue: {parameter.HasDefaultValue}");
                    Console.WriteLine($"-> IsIn : {parameter.IsIn}");
                    Console.WriteLine($"-> IsOut : {parameter.IsOut}");
                    Console.WriteLine($"-> IsOptional : {parameter.IsOptional}");
                }
            }
            Console.WriteLine("Constructor methods");
            foreach (var ctor in type.GetMethods())
            {
                Console.WriteLine($"-> IsPublic: {ctor.IsPublic}");
                Console.WriteLine($"-> IsStatic: {ctor.IsStatic}");
                Console.WriteLine($"-> IsPrivate: {ctor.IsPrivate}");
                Console.WriteLine($"-> ContainsGenericParameters: {ctor.ContainsGenericParameters}");
                Console.WriteLine($"-> IsAbstract: {ctor.IsAbstract}");
                Console.WriteLine($"-> IsAssembly: {ctor.IsAssembly}");
                Console.WriteLine($"-> IsCollectible: {ctor.IsCollectible}");
                Console.WriteLine($"-> IsConstructedGenericMethod: {ctor.IsConstructedGenericMethod}");
                Console.WriteLine($"-> IsConstructor: {ctor.IsConstructor}");
                Console.WriteLine($"-> IsFamily: {ctor.IsFamily}");
                Console.WriteLine($"-> IsFamilyAndAssembly: {ctor.IsFamilyAndAssembly}");
                Console.WriteLine($"-> IsFamilyOrAssembly: {ctor.IsFamilyOrAssembly}");
                Console.WriteLine($"-> IsFinal: {ctor.IsFinal}");
                Console.WriteLine($"-> IsVirtual: {ctor.IsVirtual}");
                foreach (var parameter in ctor.GetParameters())
                {
                    Console.WriteLine($"-> ParameterType.Name: {parameter.ParameterType.Name}");
                    Console.WriteLine($"-> Name: {parameter.Name}");
                    Console.WriteLine($"-> Member.Name : {parameter.Member.Name}");
                    Console.WriteLine($"-> DefaultValue : {parameter.DefaultValue}");
                    Console.WriteLine($"-> HasDefaultValue: {parameter.HasDefaultValue}");
                    Console.WriteLine($"-> IsIn : {parameter.IsIn}");
                    Console.WriteLine($"-> IsOut : {parameter.IsOut}");
                    Console.WriteLine($"-> IsOptional : {parameter.IsOptional}");
                }
            }
        }
    }
}
