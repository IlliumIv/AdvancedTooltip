using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System.Windows.Forms;

namespace AdvancedTooltip.Settings
{
    public class AdvancedTooltipSettings : ISettings
    {
        public AdvancedTooltipSettings()
        {
            Enable = new ToggleNode(false);
            Debug = new ToggleNode(false);
            ItemLevel = new ItemLevelSettings();
            ItemMods = new ItemModsSettings();
            WeaponDps = new WeaponDpsSettings();
        }

        [Menu("Item Level", 10)]
        public ItemLevelSettings ItemLevel { get; set; }
        [Menu("Item Mods", 20)]
        public ItemModsSettings ItemMods { get; set; }
        [Menu("Weapon Dps", 30)]
        public WeaponDpsSettings WeaponDps { get; set; }
        [Menu("Enable Tooltips Draw", 40)]
        public HotkeyNode DrawTooltips { get; set; } = new HotkeyNode(Keys.F9);
        public ToggleNode Enable { get; set; }
        public ToggleNode Debug { get; set; }
    }
}
