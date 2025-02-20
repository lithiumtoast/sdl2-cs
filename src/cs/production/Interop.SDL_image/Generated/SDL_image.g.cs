// <auto-generated>
//  This code was generated by the following tool on 2025-02-20 01:58:45 GMT+00:00:
//      https://github.com/bottlenoselabs/c2cs (v2025.2.20.0)
//
//  Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ReSharper disable All

#region Template

#pragma warning disable CS1591
#pragma warning disable CS8981
using Interop.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#endregion

using static bottlenoselabs.Interop.SDL;


namespace bottlenoselabs.Interop;

public static unsafe partial class SDL_image
{
    private const string LibraryName = "SDL3_image";

    [LibraryImport(LibraryName, EntryPoint = "IMG_FreeAnimation")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void IMG_FreeAnimation(IMG_Animation* anim);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isAVIF")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isAVIF(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isBMP")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isBMP(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isCUR")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isCUR(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isGIF")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isGIF(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isICO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isICO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isJPG")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isJPG(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isJXL")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isJXL(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isLBM")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isLBM(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isPCX")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isPCX(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isPNG")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isPNG(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isPNM")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isPNM(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isQOI")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isQOI(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isSVG")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isSVG(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isTIF")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isTIF(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isWEBP")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isWEBP(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isXCF")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isXCF(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isXPM")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isXPM(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_isXV")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_isXV(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_Load")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_Load(CString file);

    [LibraryImport(LibraryName, EntryPoint = "IMG_Load_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_Load_IO(SDL_IOStream* src, CBool closeio);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadAnimation")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IMG_Animation* IMG_LoadAnimation(CString file);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadAnimation_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IMG_Animation* IMG_LoadAnimation_IO(SDL_IOStream* src, CBool closeio);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadAnimationTyped_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IMG_Animation* IMG_LoadAnimationTyped_IO(SDL_IOStream* src, CBool closeio, CString type);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadAVIF_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadAVIF_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadBMP_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadBMP_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadCUR_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadCUR_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadGIF_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadGIF_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadGIFAnimation_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IMG_Animation* IMG_LoadGIFAnimation_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadICO_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadICO_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadJPG_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadJPG_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadJXL_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadJXL_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadLBM_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadLBM_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadPCX_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadPCX_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadPNG_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadPNG_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadPNM_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadPNM_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadQOI_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadQOI_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadSizedSVG_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadSizedSVG_IO(SDL_IOStream* src, int width, int height);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadSVG_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadSVG_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadTexture")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Texture* IMG_LoadTexture(SDL_Renderer* renderer, CString file);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadTexture_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Texture* IMG_LoadTexture_IO(SDL_Renderer* renderer, SDL_IOStream* src, CBool closeio);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadTextureTyped_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Texture* IMG_LoadTextureTyped_IO(SDL_Renderer* renderer, SDL_IOStream* src, CBool closeio, CString type);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadTGA_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadTGA_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadTIF_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadTIF_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadTyped_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadTyped_IO(SDL_IOStream* src, CBool closeio, CString type);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadWEBP_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadWEBP_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadWEBPAnimation_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IMG_Animation* IMG_LoadWEBPAnimation_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadXCF_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadXCF_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadXPM_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadXPM_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_LoadXV_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_LoadXV_IO(SDL_IOStream* src);

    [LibraryImport(LibraryName, EntryPoint = "IMG_ReadXPMFromArray")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_ReadXPMFromArray(CString* xpm);

    [LibraryImport(LibraryName, EntryPoint = "IMG_ReadXPMFromArrayToRGB888")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial SDL_Surface* IMG_ReadXPMFromArrayToRGB888(CString* xpm);

    [LibraryImport(LibraryName, EntryPoint = "IMG_SaveAVIF")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_SaveAVIF(SDL_Surface* surface, CString file, int quality);

    [LibraryImport(LibraryName, EntryPoint = "IMG_SaveAVIF_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_SaveAVIF_IO(SDL_Surface* surface, SDL_IOStream* dst, CBool closeio, int quality);

    [LibraryImport(LibraryName, EntryPoint = "IMG_SaveJPG")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_SaveJPG(SDL_Surface* surface, CString file, int quality);

    [LibraryImport(LibraryName, EntryPoint = "IMG_SaveJPG_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_SaveJPG_IO(SDL_Surface* surface, SDL_IOStream* dst, CBool closeio, int quality);

    [LibraryImport(LibraryName, EntryPoint = "IMG_SavePNG")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_SavePNG(SDL_Surface* surface, CString file);

    [LibraryImport(LibraryName, EntryPoint = "IMG_SavePNG_IO")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CBool IMG_SavePNG_IO(SDL_Surface* surface, SDL_IOStream* dst, CBool closeio);

    [LibraryImport(LibraryName, EntryPoint = "IMG_Version")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int IMG_Version();

    public static readonly int SDL_IMAGE_MAJOR_VERSION = (int)3;

    public static readonly int SDL_IMAGE_MICRO_VERSION = (int)1;

    public static readonly int SDL_IMAGE_MINOR_VERSION = (int)2;

    public static readonly int SDL_IMAGE_VERSION = (int)3002001;

    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 8)]
    public partial struct IMG_Animation
    {
        [FieldOffset(0)]
        public int w; // size = 4

        [FieldOffset(4)]
        public int h; // size = 4

        [FieldOffset(8)]
        public int count; // size = 4

        [FieldOffset(16)]
        public SDL_Surface** frames; // size = 8

        [FieldOffset(24)]
        public int* delays; // size = 8
    }
}


