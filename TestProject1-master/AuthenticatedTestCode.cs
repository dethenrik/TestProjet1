using Bunit;
using Bunit.TestDoubles;

namespace TestProject1
{
    public class UniTest4
    {
        [Fact]
        public void AuthenticatedTest()
        {
            using var ctx = new TestContext();

            // Simulate an authenticated user
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("TestUser"); // Simulate an authenticated user with the name "TestUser"
            authContext.SetRoles("Admin"); // Assign the 'Admin' role


            // Render the component
            var cut = ctx.RenderComponent<SoftwareTest.Components.Pages.Home>();

            // Assert that the HTML rendered for an authenticated user is correct
            cut.MarkupMatches("<div>\r\n Du er logget ind (from code)\r\n</div>\r\n<div>\r\n Du er Admin\r\n</div>");
        }
    }
}