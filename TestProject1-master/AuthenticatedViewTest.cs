using Bunit;
using Bunit.TestDoubles;

namespace UnitTestProject
{
    public class UniTest5
    {
        [Fact]
        public void AuthenticatedViewTest()
        {
            using var ctx = new TestContext();

            // Simulate an authenticated user
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("TestUser");

            // Render the component
            var cut = ctx.RenderComponent<SoftwareTest.Components.Pages.Home>();

            // Assert that the view reflects the authenticated state
            cut.MarkupMatches(@"<div>Du er logget ind (from code)</div><div>Du er IKKE Admin</div>");
        }
    }
}
