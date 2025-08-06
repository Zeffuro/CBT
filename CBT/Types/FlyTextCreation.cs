// From FlyTextFilter - FlyTextCreation.cs
// https://github.com/Aireil/FlyTextFilter

namespace CBT.Types;

using System.Runtime.InteropServices;

/* Style:
 *   0 - is local player (or if source, is local player's pet)
 *   1 - is an alliance member
 *   2 - default if not the others
 *   3 - is a battle NPC, is in a duel with local player, or is a player character other than the local player in pvp instance or duel
 * If (source == 0 || target == 0) { Fly Text } else { Pop-up Text }
 *
 * (target == 0) is style 1, red on attacks.
 * (source == 0 && target == 3) is style 2, yellow on attacks.
 * (source == 3 && target != 0) is style 3, red on attacks.
 * ((source == 1 || source == 2) && target != 0) is style 4, blue on attacks.
 *
 *
 * Damage type:
 *   1 - Physical
 *   2 - Magic
 *   3 - Unique
 * */

/// <summary>
/// FlyTextCreation struct.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct FlyTextCreation
{
    /// <summary>
    /// Kind.
    /// </summary>
    public FlyTextKind FlyTextKind;

    /// <summary>
    /// SourceStyle.
    /// </summary>
    public byte SourceStyle;

    /// <summary>
    /// TargetStyle.
    /// </summary>
    public byte TargetStyle;

    /// <summary>
    /// Option.
    /// </summary>
    public byte Option;

    /// <summary>
    /// ActionKind.
    /// </summary>
    public byte ActionKind;

    /// <summary>
    /// ActionID.
    /// </summary>
    public int ActionId;

    /// <summary>
    /// Value1.
    /// </summary>
    public int Val1; // status id if icon

    /// <summary>
    /// Value2.
    /// </summary>
    public int Val2;

    /// <summary>
    /// DamageType.
    /// </summary>
    public byte DamageType;
}