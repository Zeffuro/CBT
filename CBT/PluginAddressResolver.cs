namespace CBT;

using System;
using Dalamud.Game;

/// <summary>
/// Dalamud address resolver.
/// </summary>
public class PluginAddressResolver : BaseAddressResolver
{
    /// <summary>
    /// Gets the address of AddScreenLog.
    /// </summary>
    public IntPtr AddScreenLog { get; private set; }

    /// <summary>
    /// Gets the address of ReceiveActionEffect.
    /// </summary>
    public IntPtr ReceiveActionEffect { get; private set; }

    /// <inheritdoc/>
    protected override void Setup64Bit(ISigScanner scanner)
    {
        this.AddScreenLog = scanner.ScanText("E8 ?? ?? ?? ?? BF ?? ?? ?? ?? EB 39");

        this.ReceiveActionEffect = scanner.ScanText("40 55 53 56 41 54 41 55 41 56 41 57 48 8D AC 24 ?? ?? ?? ?? 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 45 70");

        Service.PluginLog.Debug($"{nameof(this.AddScreenLog)}           0x{this.AddScreenLog:X}");
        Service.PluginLog.Debug($"{nameof(this.ReceiveActionEffect)}    0x{this.ReceiveActionEffect:X}");
    }
}