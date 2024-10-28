namespace MareSynchronos.API.Routes;

public class MareAuth
{

    public const string Auth = "/auth";
    public const string Auth_CreateIdent = "createWithIdent";
    public const string Auth_CreateOAuth = "createWithOAuth";
    public const string Auth_RenewToken = "renewToken";
    public const string Auth_RenewOAuthToken = "renewOAuthToken";
    public static Uri AuthFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_CreateIdent);
    public static Uri AuthWithOauthFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_CreateOAuth);
    public static Uri RenewTokenFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_RenewToken);
    public static Uri RenewOAuthTokenFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_RenewOAuthToken);
}