using System.Numerics;

#if POE1
using Shared = ExileCore.Shared;

#else
using Shared = ExileCore2.Shared;

#endif

namespace InputHumanizer.Input
{
    public interface IInputController : IDisposable
    {
        Shared.SyncTask<bool> KeyDown(Keys key, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> KeyUp(Keys key, bool releaseImmediately = false, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> Click(CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> Click(MouseButtons button, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> Click(MouseButtons button, Vector2? coordinate, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> ClickWithModifiers(MouseButtons button, Vector2? coordinate, MouseModifiers modifiers, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> VerticalScroll(bool forward, int numClicks, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> VerticalScroll(bool forward, int numClicks, Vector2? coordinate, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> MoveMouse(Vector2 coordinate, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> MoveMouse(Vector2 coordinate, int maxInterpolationDistance, int minInterpolationDelay, int maxInterpolationDelay, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> MoveMouseWindMouseImpl(Vector2 coordinate, double gravityStrength, double windStrength, int minInterpolationDelay, int maxInterpolationDelay, double stepSize, double targetArea, CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> ClearMousePosition(CancellationToken cancellationToken = default);
        Shared.SyncTask<Vector2?> GetCursorPos(CancellationToken cancellationToken = default);
        Shared.SyncTask<bool> ReleaseControl(CancellationToken cancellationToken = default);
        void SetDelayOverrides(int minDelay = -1, int maxDelay = -1, int mean = -1, int standardDeviation = -1);

        int GenerateDelay();
    }
}
