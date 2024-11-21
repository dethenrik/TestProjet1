using Bunit;
using Bunit.TestDoubles;

namespace UnitTestProject
{
    public class UniTest6
    {
        [Fact]
        public void NotAuthenticatedCodeTest()
        {
            using var ctx = new TestContext();

            // Set up the authentication context with no user
            var authContext = ctx.AddTestAuthorization(); // No user is authorized

            // Render the component
            var cut = ctx.RenderComponent<SoftwareTest.Components.Pages.Home>();
            var myObject = cut.Instance;

            // Assert that the code logic reflects the "not authenticated" state
            Assert.False(myObject._isAuthenticated);
            Assert.False(myObject._isAdmin); // Not admin if not authenticated
        }
    }
}