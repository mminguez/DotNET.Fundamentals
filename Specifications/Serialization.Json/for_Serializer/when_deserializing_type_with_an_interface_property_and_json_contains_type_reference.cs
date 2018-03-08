﻿using System;
using Dolittle.Serialization.Json;
using Machine.Specifications;

namespace Dolittle.Serialization.Json.Specs.for_Serializer
{
    public class when_deserializing_type_with_an_interface_property_and_json_contains_type_reference : given.a_serializer
    {
        const string json = "{\"Something\":{\"$type\":\"Dolittle.Serialization.Json.Specs.for_Serializer.SomethingImplementation, Dolittle.Serialization.Json.Specs\",\"SomeValue\":\"Something\"}}";

        static ClassToSerialize instance;

        Establish context = () =>
                                {
                                    container_mock.Setup(c => c.Get<ClassToSerialize>()).Returns(new ClassToSerialize());
                                    container_mock.Setup(c => c.Get(Moq.It.IsAny<Type>())).Returns((Type t) => Activator.CreateInstance(t));
                                };

        Because of = () => instance = serializer.FromJson<ClassToSerialize>(json, SerializationOptions.IncludeTypeNames);

        It should_have_the_property_instance_set_to_instance_of_SomethingImplementation = () => instance.Something.ShouldBeOfExactType<SomethingImplementation>();
    }
}