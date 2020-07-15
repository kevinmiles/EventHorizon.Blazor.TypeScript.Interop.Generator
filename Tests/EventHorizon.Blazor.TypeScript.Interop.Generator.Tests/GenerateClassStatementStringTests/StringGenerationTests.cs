﻿using System.IO;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class StringGenerationTests : GenerateStringTestBase
    {
        [Theory(DisplayName = "Constructor")]
        [Trait("Category", "StringGeneration.Constructors")]
        [InlineData("NoConstructor.ts", "Constructors", "NoConstructor.Expected.txt")]
        [InlineData("WithNullArguments.ts", "Constructors", "WithNullArguments.Expected.txt")]
        [InlineData("WithActionArgument.ts", "Constructors", "WithActionArgument.Expected.txt")]
        public void ShouldGenerateConstructorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticAccessor")]
        [Trait("Category", "StringGeneration.StaticAccessors")]
        [InlineData("AccessorStaticClass.ts", "Accessors", "AccessorStaticClass.Expected.txt")]
        [InlineData("AccessorStaticClassArray.ts", "Accessors", "AccessorStaticClassArray.Expected.txt")]
        [InlineData("AccessorStaticPrimitive.ts", "Accessors", "AccessorStaticPrimitive.Expected.txt")]
        [InlineData("AccessorStaticPrimitiveArray.ts", "Accessors", "AccessorStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticAccessorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticProperties")]
        [Trait("Category", "StringGeneration.StaticProperties")]
        [InlineData("PropertyStaticClass.ts", "Properties", "PropertyStaticClass.Expected.txt")]
        [InlineData("PropertyStaticClassArray.ts", "Properties", "PropertyStaticClassArray.Expected.txt")]
        [InlineData("PropertyStaticPrimitive.ts", "Properties", "PropertyStaticPrimitive.Expected.txt")]
        [InlineData("PropertyStaticPrimitiveArray.ts", "Properties", "PropertyStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticPropertyStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticMethods")]
        [Trait("Category", "StringGeneration.StaticMethods")]
        [InlineData("MethodStaticVoid.ts", "Methods", "MethodStaticVoid.Expected.txt")]
        [InlineData("MethodStaticClass.ts", "Methods", "MethodStaticClass.Expected.txt")]
        [InlineData("MethodStaticClassArray.ts", "Methods", "MethodStaticClassArray.Expected.txt")]
        [InlineData("MethodStaticPrimitive.ts", "Methods", "MethodStaticPrimitive.Expected.txt")]
        [InlineData("MethodStaticPrimitiveArray.ts", "Methods", "MethodStaticPrimitiveArray.Expected.txt")]
        public void ShouldGenerateStaticMethodStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "StaticMethod.Scenarios")]
        [Trait("Category", "StringGeneration.StaticMethod.Scenarios")]
        [InlineData("MethodStaticClassWithLiteralInArguments.ts", "Methods", "Scenarios", "MethodStaticClassWithLiteralInArguments.Expected.txt")]
        [InlineData("MethodStaticClassWithNullArgument.ts", "Methods", "Scenarios", "MethodStaticClassWithNullArgument.Expected.txt")]
        [InlineData("MethodStaticClassWithUndefinedArgument.ts", "Methods", "Scenarios", "MethodStaticClassWithUndefinedArgument.Expected.txt")]
        [InlineData("MethodStaticAction.ts", "Methods", "Scenarios", "MethodStaticAction.Expected.txt")]
        [InlineData("MethodStaticWithLiteralAsResult.ts", "Methods", "Scenarios", "MethodStaticWithLiteralAsResult.Expected.txt")]
        public void ShouldGenerateStaticMethodScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Accessor")]
        [Trait("Category", "StringGeneration.Accessors")]
        [InlineData("AccessorClass.ts", "Accessors", "AccessorClass.Expected.txt")]
        [InlineData("AccessorClassArray.ts", "Accessors", "AccessorClassArray.Expected.txt")]
        [InlineData("AccessorPrimitive.ts", "Accessors", "AccessorPrimitive.Expected.txt")]
        [InlineData("AccessorPrimitiveArray.ts", "Accessors", "AccessorPrimitiveArray.Expected.txt")]
        public void ShouldGenerateAccessorStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Accessor.Scenarios")]
        [Trait("Category", "StringGeneration.Accessor.Scenarios")]
        [InlineData("AccessorSetNoGet.ts", "Accessors", "Scenarios", "AccessorSetNoGet.Expected.txt")]
        [InlineData("GenericObserver.ts", "Accessors", "Scenarios", "GenericObserver.Expected.txt")]
        [InlineData("NullableTyping.ts", "Accessors", "Scenarios", "NullableTyping.Expected.txt")]
        [InlineData("InterfaceResponse.ts", "Accessors", "Scenarios", "InterfaceResponse.Expected.txt")]
        public void ShouldGenerateAccessorScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Properties")]
        [Trait("Category", "StringGeneration.Properties")]
        [InlineData("PropertyClass.ts", "Properties", "PropertyClass.Expected.txt")]
        [InlineData("PropertyClassArray.ts", "Properties", "PropertyClassArray.Expected.txt")]
        [InlineData("PropertyPrimitive.ts", "Properties", "PropertyPrimitive.Expected.txt")]
        [InlineData("PropertyPrimitiveArray.ts", "Properties", "PropertyPrimitiveArray.Expected.txt")]
        public void ShouldGeneratePropertyStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Property.Scenarios")]
        [Trait("Category", "StringGeneration.Property.Scenarios")]
        [InlineData("PropertyJavaScriptTypes.ts", "Properties", "Scenarios", "PropertyJavaScriptTypes.Expected.txt")]
        [InlineData("PropertyParenthesized.ts", "Properties", "Scenarios", "PropertyParenthesized.Expected.txt")]
        [InlineData("TypeofResponse.ts", "Properties", "Scenarios", "TypeofResponse.Expected.txt")]
        public void ShouldGeneratePropertyScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "ArrayTypes")]
        [Trait("Category", "StringGeneration.ArrayTypes")]
        [InlineData("PropertyArrayTypes.ts", "Properties", "PropertyArrayTypes.Expected.txt")]
        public void ShouldGenerateArrayTypeStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Methods")]
        [Trait("Category", "StringGeneration.Methods")]
        [InlineData("MethodClass.ts", "Methods", "MethodClass.Expected.txt")]
        [InlineData("MethodClassArray.ts", "Methods", "MethodClassArray.Expected.txt")]
        [InlineData("MethodPrimitive.ts", "Methods", "MethodPrimitive.Expected.txt")]
        [InlineData("MethodPrimitiveArray.ts", "Methods", "MethodPrimitiveArray.Expected.txt")]
        [InlineData("MethodVoid.ts", "Methods", "MethodVoid.Expected.txt")]
        public void ShouldGenerateMethodStrings(
            string sourceFile,
            string path,
            string expectedFile
        ) => ValidateGenerateStrings(
            path,
            sourceFile,
            expectedFile
        );

        [Theory(DisplayName = "Method.Scenarios")]
        [Trait("Category", "StringGeneration.Method.Scenarios")]
        [InlineData("ActionWithArguments.ts", "Methods", "Scenarios", "ActionWithArguments.Expected.txt")]
        [InlineData("GenericsInArguments.ts", "Methods", "Scenarios", "GenericsInArguments.Expected.txt")]
        [InlineData("MethodThisAsResult.ts", "Methods", "Scenarios", "MethodThisAsResult.Expected.txt")]
        [InlineData("MethodNullableTypeReference.ts", "Methods", "Scenarios", "MethodNullableTypeReference.Expected.txt")]
        [InlineData("NullableTyping.ts", "Methods", "Scenarios", "NullableTyping.Expected.txt")]
        [InlineData("PromiseResponse.ts", "Methods", "Scenarios", "PromiseResponse.Expected.txt")]
        public void ShouldGenerateMethodScenarioStrings(
            string sourceFile,
            string rootPath,
            string scenariosPath,
            string expectedFile
        ) => ValidateGenerateStrings(
            Path.Combine(rootPath, scenariosPath),
            sourceFile,
            expectedFile
        );
    }
}