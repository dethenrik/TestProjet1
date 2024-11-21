using Bunit;
using Bunit.TestDoubles;

namespace UnitTestProject
{
    public class UniTest1
    {
        [Fact]
        public void AdminCodeTest()
        {
            using var ctx = new TestContext();

            // Simulate an authenticated user with "Admin" role
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("TestUser");
            authContext.SetRoles("Admin");

            // Render the component
            var cut = ctx.RenderComponent<SoftwareTest.Components.Pages.Home>();
            var myObject = cut.Instance;

            // Assert that the code logic reflects admin role
            Assert.True(myObject._isAuthenticated);
            Assert.True(myObject._isAdmin); // Admin role is assigned
        }
    }
}
