using Dolittle.Concepts;
using Machine.Specifications;

namespace Dolittle.Specs.Concepts.for_ConceptAs
{
    [Subject(typeof(ConceptAs<>))]
    public class when_equating : given.concepts
    {
        static bool result_of_equality;
        static bool result_of_operator_equality;
        static bool result_of_equality_on_same_reference;
        static bool result_of_operator_equality_on_same_reference;
        static bool result_of_equality_on_same_value;
        static bool result_of_operator_equality_on_same_value;
        static bool result_of_inequality_operator;
        static bool result_of_inequality_operator_on_same_reference;
        static bool result_of_inequality_operator_on_same_value;
        static bool result_of_equality_on_two_different_concept_types_based_on_same_underlying_type_with_same_values;

        Because of = () =>
            {
                result_of_equality = first_string.Equals(second_string);
                result_of_equality_on_same_reference = first_string.Equals(first_string);
                result_of_equality_on_same_value = second_string.Equals(same_value_as_second_string);

                result_of_operator_equality = first_string == second_string;
#pragma warning disable 1718 // this is the point of the spec - so ignore the warning
                result_of_operator_equality_on_same_reference = first_string == first_string;
#pragma warning restore 1718
                result_of_operator_equality_on_same_value = second_string == same_value_as_second_string;

                result_of_inequality_operator = first_string != second_string;
#pragma warning disable 1718 // this is the point of the spec - so ignore the warning
                result_of_inequality_operator_on_same_reference = first_string != first_string;
#pragma warning restore 1718
                result_of_inequality_operator_on_same_value = second_string != same_value_as_second_string;

                result_of_equality_on_two_different_concept_types_based_on_same_underlying_type_with_same_values
                    = value_as_a_long.Equals(value_as_an_int);
            };

        It should_not_equate_two_differing_concepts = () => result_of_equality.ShouldBeFalse();
        It should_equate_the_same_reference = () => result_of_equality_on_same_reference.ShouldBeTrue();
        It should_equate_the_same_value = () => result_of_equality_on_same_value.ShouldBeTrue();
        It should_not_equate_by_operator_two_differing_concepts = () => result_of_operator_equality.ShouldBeFalse();
        It should_equate_by_operator_the_same_reference = () => result_of_operator_equality_on_same_reference.ShouldBeTrue();
        It should_equate_by_operator_the_same_value = () => result_of_operator_equality_on_same_value.ShouldBeTrue();
        It should_not_equate_two_differing_concepts_by_inequality_operator = () => result_of_inequality_operator.ShouldBeTrue();
        It should_equate_the_same_reference_by_inequality_operator = () => result_of_inequality_operator_on_same_reference.ShouldBeFalse();
        It should_equate_the_same_value_by_inequality_operator = () => result_of_inequality_operator_on_same_value.ShouldBeFalse();
        It should_not_equate_different_types_based_on_same_value_of_underlying_type = () =>
            result_of_equality_on_two_different_concept_types_based_on_same_underlying_type_with_same_values.ShouldBeFalse();
    }
}