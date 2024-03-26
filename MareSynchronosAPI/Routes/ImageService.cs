namespace MareSynchronos.API.Routes;

public class ImageService
{
    public const string Image = "/image";
    public const string Image_GetImage = "getImage";
    public const string Image_GetImageThumb = "getImageThumb";
    public const string Image_StoreImage = "storeImage";
    public static Uri GetImageFullPath(Uri baseUri, Guid imageId) => new Uri(baseUri, Image + "/" + Image_GetImage + "?imageId=" + imageId.ToString());
    public static Uri GetImageThumbFullPath(Uri baseUri, Guid imageId) => new Uri(baseUri, Image + "/" + Image_GetImageThumb + "?imageId=" + imageId.ToString());
    public static Uri StoreImgeFullPath(Uri baseUri) => new Uri(baseUri, Image + "/" + Image_StoreImage);
}
