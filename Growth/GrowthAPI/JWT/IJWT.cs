using GrowthModels;

namespace GrowthAPI.JWT
{
    public interface IJWT
    {
        Tokens AuthUser(UserAccount user);
    }
}
