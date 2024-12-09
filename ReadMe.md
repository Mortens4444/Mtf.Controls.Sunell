# Mtf.Controls.Sunell Documentation

## Overview

This documentation provides guidance on using the `Mtf.Controls.Sunell` library in your project, specifically the `SunellVideoWindow` control that integrates with Sunell cameras for live video streaming.

To install the `Mtf.Controls.Sunell` package, follow these steps:

1. **Add Package**:
   - Open the terminal in your project directory.
   - Run the following command:

     ```bash
     dotnet add package Mtf.Controls.Sunell
     ```

   This will automatically download and reference the `Mtf.Controls.Sunell` library in your project.

2. **Include the Namespace**:
   At the top of your code file, include the `Mtf.Controls.Sunell` namespace:

   ```csharp
   using Mtf.Controls.Sunell;
   ```

## Using SunellVideoWindow Control

The `SunellVideoWindow` control in `Mtf.Controls.Sunell` provides a custom window for displaying video streams from Sunell cameras. It supports connecting to a camera, streaming live video, and displaying error messages when issues arise.

### Attributes
- `[ToolboxItem(true)]` – Ensures that the control is available in the Toolbox.
- `[ToolboxBitmap(typeof(SunellVideoWindow), "Resources.VideoSource.png")]` – Associates an icon for the control in the Toolbox.

### Constructor

- **SunellVideoWindow()**: Initializes a new `SunellVideoWindow` and sets up the control for displaying video.

### Properties

| Property          | Type     | Description                                                                                     |
|-------------------|----------|-------------------------------------------------------------------------------------------------|
| `OverlayText`     | `string` | The text to display on the control (e.g., error messages or status). Default is `String.Empty`. |
| `OverlayFont`     | `Font`   | The font used for overlay text. Default is Arial, 32pt, Bold.                                   |
| `OverlayBrush`    | `Brush`  | The color brush used for overlay text. Default is white.                                        |
| `OverlayLocation` | `Point`  | The location of the overlay text. Default is `(10, 10)`.                                        |
| `IsConnected`     | `bool`   | Indicates whether the camera is connected. Default is `false`.                                  |

### Methods

- **Connect(string cameraIp, ushort cameraPort, string username, string password)**: Connects to a Sunell camera using the provided IP, port, username, and password.
- **Disconnect()**: Disconnects from the currently connected camera.
- **PTZ_Open(int cameraId)**: Opens the PTZ (Pan-Tilt-Zoom) control for the specified camera.
- **PTZ_Close()**: Closes the PTZ control.
- **PTZ_Stop()**: Stops any PTZ movement.
- **PTZ_RotateUp(int speed)**: Rotates the PTZ up with the specified speed.
- **PTZ_RotateDown(int speed)**: Rotates the PTZ down with the specified speed.
- **PTZ_RotateRight(int speed)**: Rotates the PTZ right with the specified speed.
- **PTZ_RotateLeft(int speed)**: Rotates the PTZ left with the specified speed.

### Events

- **VideoSignalChanged**: Triggered when the video signal changes (e.g., successful connection or error). The event handler receives a `VideoSignalChangedEventArgs` object with a `bool` indicating whether the video signal is active.

### Example Usage

```csharp
using System;
using System.Windows.Forms;
using Mtf.Controls.Sunell;

public class CameraForm : Form
{
    private SunellVideoWindow videoWindow;

    public CameraForm()
    {
        videoWindow = new SunellVideoWindow
        {
            Location = new System.Drawing.Point(10, 10),
            Width = 640,
            Height = 480
        };
        Controls.Add(videoWindow);

        videoWindow.VideoSignalChanged += (sender, e) =>
        {
            if (e.IsSignalActive)
            {
                Console.WriteLine("Video signal is active.");
            }
            else
            {
                Console.WriteLine("Error: No video signal.");
            }
        };
    }

    public void ConnectToCamera()
    {
        videoWindow.Connect("192.168.1.100", 554, "admin", "password");
    }

    public void DisconnectFromCamera()
    {
        videoWindow.Disconnect();
    }
}
```

In this example, `CameraForm` creates a `SunellVideoWindow` and connects it to a camera using the `ConnectToCamera` method. The form also handles the `VideoSignalChanged` event to display the status of the video signal.

### Notes
- The `Connect` method manages both old and new Sunell camera connections, with error handling for unsupported or incorrect credentials.
- PTZ controls can be used to control the camera's movement remotely.
- The `SetLastError` method is used to handle error messages and display them on the `Text` property of the control.

## Important Notes

- Ensure your project has the required .NET dependencies to support `Mtf.Controls.Sunell`.
- For more details on using specific methods or properties, refer to the `Mtf.Controls.Sunell` [GitHub Repository](https://github.com/Mortens4444/Mtf.Controls).
- If you encounter issues with the Visual Studio Toolbox, remove all files from `C:\Users\[username]\AppData\Local\Microsoft\VisualStudio\[vs_version_]\ComponentModelCache` and rebuild the project to refresh the toolbox.
