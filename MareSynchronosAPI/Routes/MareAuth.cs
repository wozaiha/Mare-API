namespace MareSynchronos.API.Routes;

public class MareAuth
{
    public const string Auth = "/auth";
    public const string Auth_CreateIdent = "createWithIdent";
    public const string Auth_RenewToken = "renewToken";
    public static Uri AuthFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_CreateIdent);
    public static Uri RenewTokenFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_RenewToken);
}