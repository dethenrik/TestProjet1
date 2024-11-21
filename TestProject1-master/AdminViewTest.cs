using Bunit;
using Bunit.TestDoubles;

namespace UnitTestProject
{
    public class UniTest2
    {
        [Fact]
        public void AdminViewTest()
        {
            using var ctx = new TestContext();

            // Simulate an authenticated user with "Admin" role
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("TestUser");
            authContext.SetRoles("Admin");

            // Render the component
            var cut = ctx.RenderComponent<SoftwareTest.Components.Pages.Home>();

            // Assert that the view reflects the "admin" state
            cut.MarkupMatches(@"<div>Du er logget ind (from code)</div><div>Du er Admin</div>");
        }
    }
}