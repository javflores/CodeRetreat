using Machine.Specifications;
using TheGameOfLife;

namespace TheGameOfLifeTest
{
    [Subject("Application")] 
    public class When_creating_game_of_life
    {
        It should_successfully_start_application = () => _result.ShouldEqual(true);

        Because of = () => _result = _subject.Start();

        Establish context = () => _subject = new Application();

        private static Application _subject;
        private static bool _result;
    }
}
