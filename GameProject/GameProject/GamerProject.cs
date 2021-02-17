using GameProject.Concrete;

namespace GameProject
{
    internal class GamerProject
    {
        private UserValidationManager userValidationManager;

        public GamerProject(UserValidationManager userValidationManager)
        {
            this.userValidationManager = userValidationManager;
        }
    }
}