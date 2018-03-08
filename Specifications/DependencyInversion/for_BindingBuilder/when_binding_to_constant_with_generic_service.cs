using Machine.Specifications;

namespace Dolittle.DependencyInversion.for_BindingBuilder
{
    public class when_binding_to_constant_with_generic_service : given.a_null_binding_for_generic_builder
    {
        const string target = "Fourty Two";
        static Binding result;

        Because of = () => 
        {
            builder.To(target);
            result = builder.Build();
        };

        It should_have_a_constant_strategy = () => result.Strategy.ShouldBeOfExactType<Strategies.Constant>();
        It should_hold_the_constant_in_the_strategy = () => ((Strategies.Constant)result.Strategy).Target.ShouldEqual(target);
        It should_have_transient_scope = () => result.Scope.ShouldBeAssignableTo<Scopes.Transient>();
    }
}