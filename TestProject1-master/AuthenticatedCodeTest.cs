using Bunit;
using Bunit.TestDoubles;

namespace UnitTestProject
{
    public class UniTest3
    {
        [Fact]
        public void AuthenticatedCodeTest()
        {
            using var ctx = new TestContext();

            // Simulate an authenticated user
            var authContext = ctx.AddTestAuthorization();
            authContext.SetAuthorized("TestUser");

            // Render the component
            var cut = ctx.RenderComponent<SoftwareTest.Components.Pages.Home>();
            var myObject = cut.Instance;

            // Assert that the code logic reflects authentication state
            Assert.True(myObject._isAuthenticated);
            Assert.False(myObject._isAdmin); // User is not an admin in this case
        }
    }
}
