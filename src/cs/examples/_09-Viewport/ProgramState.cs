// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

namespace SDL.Examples;

public unsafe class ProgramState
{
    public readonly int ScreenWidth = 640;
    public readonly int ScreenHeight = 480;

    public SDL_Window* Window = null;
    public SDL_Renderer* Renderer = null;
    public SDL_Texture* Texture = null;
}
