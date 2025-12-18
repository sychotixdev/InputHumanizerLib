using System;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;
using ExileCore2.Shared;

namespace InputHumanizer.Input
{
    public interface IInputController : IDisposable
    {
        SyncTask<bool> KeyDown(Keys key, CancellationToken cancellationToken = default);
        SyncTask<bool> KeyUp(Keys key, bool releaseImmediately = false, CancellationToken cancellationToken = default);
        SyncTask<bool> Click(CancellationToken cancellationToken = default);
        SyncTask<bool> Click(MouseButtons button, CancellationToken cancellationToken = default);
        SyncTask<bool> Click(MouseButtons button, Vector2 coordinate, CancellationToken cancellationToken = default);
        SyncTask<bool> VerticalScroll(bool forward, int numClicks, CancellationToken cancellationToken = default);
        SyncTask<bool> VerticalScroll(bool forward, int numClicks, Vector2? coordinate, CancellationToken cancellationToken = default);
        SyncTask<bool> MoveMouse(Vector2 coordinate, CancellationToken cancellationToken = default);
        SyncTask<bool> MoveMouse(Vector2 coordinate, int maxInterpolationDistance, int minInterpolationDelay, int maxInterpolationDelay, CancellationToken cancellationToken = default);
        int GenerateDelay();
    }
}
