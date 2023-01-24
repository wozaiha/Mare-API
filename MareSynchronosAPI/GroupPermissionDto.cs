namespace MareSynchronos.API;

public record GroupPermissionDto
{
    public bool? DisableSounds { get; set; }
    public bool? DisableAnimations { get; set; }
}