using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BL3WebApp.Data;
using System;
using System.Linq;

namespace BL3WebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BL3WebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<BL3WebAppContext>>()))
            {
                // Look for items
                if (context.Item.Any())
                {
                    return; // Already data
                }

                context.Item.AddRange(
                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Kritchy",
                        Element = "O",
                        Location = "Cursehaven",
                        Name = "Clairvoyance",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "A broken smile beneath her whispered wings.",
                        Summary = "Crit sticks projectiles which later explode",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Fungal Gorger",
                        Element = "N",
                        Location = "The Cankerwood",
                        Name = "Mutant",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Super unnatural.",
                        Summary = "Full-Auto laser",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "F",
                        Location = null,
                        Name = "Seeryul Killur",
                        QuestChallengeName = null,
                        RedText = "Look at that unsubtle blood-red coloring...",
                        Summary = "Kill grants increased dmg, fire rate & reduces heat. Stacks 3 times",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Tom & Xam",
                        Element = "Any",
                        Location = "Heart's Desire",
                        Name = "Soulrender",
                        QuestChallengeName = "The Call of Gythian",
                        RedText = "Picture a soul. Now REND that thing!",
                        Summary = "Sends out homing purple ghosts while firing that explode on impact",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Wendigo",
                        Element = "F",
                        Location = "The Cankerwood",
                        Name = "Stauros' Burn",
                        QuestChallengeName = "Horror in the Woods",
                        RedText = "A long sigh was heard...",
                        Summary = "Chance on break to combust. Combust = guarantees crit hits & +fire dmg",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Kukuwajack",
                        Element = "O",
                        Location = "Negul Neshai",
                        Name = "Frozen Devil",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Not sorry, not sorry, not sorry.",
                        Summary = "Continuous laser / Ice Spike",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Shiverous the Unscathed",
                        Element = "O",
                        Location = "Negul Neshai",
                        Name = "Hydrafrost",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Tell your heads to chill.",
                        Summary = "After a kill, every 2nd shot deals 200% shock or incendiary dmg for 6 sec",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Yeti",
                        Element = "N",
                        Location = "Skittermaw Basin",
                        Name = "Little Yeeti",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Yeet 'em if you got 'em!",
                        Summary = "Multiple projectiles. Chance to knockback enemies",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Eleanor of the Heart",
                        Element = "N",
                        Location = "Heart's Desire",
                        Name = "Love Drill",
                        QuestChallengeName = "The Call of Gythian",
                        RedText = "...till death us depart.",
                        Summary = "20% chance to deal double dmg as shock dmg",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Quest Reward",
                        Element = "O",
                        Location = "The Cankerwood",
                        Name = "Seventh Sense",
                        QuestChallengeName = "CC: Forgotten Answers",
                        RedText = "Something so close, and yet... so distant.",
                        Summary = "Reloading causes all spawned projectiles to hit the original target",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "Any",
                        Location = null,
                        Name = "Anarchy",
                        QuestChallengeName = null,
                        RedText = "The stacks... THE STACKS!",
                        Summary = "Auto reload or kill grants 30% dmg & reduces accuracy. Max 10 stacks",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "F",
                        Location = null,
                        Name = "Flama Diddle",
                        QuestChallengeName = null,
                        RedText = "VIII. Never turn your back on the Monster!",
                        Summary = "Reload shoots twice before exploding on impact. Bullets ricochet once",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "F C S R O",
                        Location = null,
                        Name = "Insider",
                        QuestChallengeName = null,
                        RedText = "You can run, but you can't hide.",
                        Summary = "No charge time. Shots penetrate enemies",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Gmork",
                        Element = "F C S R O",
                        Location = "The Cankerwood",
                        Name = "Nothingness",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "A hole would be something.",
                        Summary = "Charged shot for several consecutive explosions (similar to the Flakker)",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Voltborn",
                        Element = "S",
                        Location = "Negul Neshai",
                        Name = "Shocker",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Everything has to be magical. Surprise!",
                        Summary = "Shock orb that splits into 3 orbs horizontally",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "[Any]",
                        Location = null,
                        Name = "Oldridian",
                        QuestChallengeName = null,
                        RedText = "They bound the ones they knew of. There were more.",
                        Summary = "Switches element on reload. Weapon shield reduces elemental dmg 20%",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "DJ Spinsmouth",
                        Element = "F C S R O",
                        Location = "Skittermaw Basin",
                        Name = "SF Force",
                        QuestChallengeName = "Sinister Sounds",
                        RedText = "Flavor-blast them all.",
                        Summary = "Shoots musical notes of both elements",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Portal Chests",
                        Element = "N",
                        Location = null,
                        Name = "Cocky Bastard",
                        QuestChallengeName = null,
                        RedText = "Great, kid.",
                        Summary = "Crit deals additional +100% dmg as shock dmg",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "N",
                        Location = null,
                        Name = "Skullmasher",
                        QuestChallengeName = null,
                        RedText = "Makes your brain hurt.",
                        Summary = "x5 projectiles per shot. Extremely fast fire rate",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Amach",
                        Element = "N",
                        Location = "Cursehaven",
                        Name = "Unseen Threat",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Taste their fear.",
                        Summary = "Crit ricochets 3 homing projectiles",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Jackpot",
                        Element = "Any",
                        Location = "VIP Tower",
                        Name = "Craps",
                        QuestChallengeName = "All Bets Off",
                        RedText = "Oh, me.",
                        Summary = "Chance to fire a circle of projectiles",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Scraptrap Prime",
                        Element = "N",
                        Location = "The Compactor",
                        Name = "Lucky 7",
                        QuestChallengeName = "One Man's Treasure",
                        RedText = "O Fortuna.",
                        Summary = "25% chance for: crit, explosive, full-auto, ricochet, amp, or 7 projectiles",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Loco Chantelle",
                        Element = "N",
                        Location = "VIP Tower",
                        Name = "Nukem",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Name dropper.",
                        Summary = "Mortar rockets with large splash radius",
                        Type = "RPG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Junpai Goat Eater",
                        Element = "Any",
                        Location = "VIP Tower",
                        Name = "Creamer",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Non-dairy.",
                        Summary = "Heals you when damaging enemy. Projectile nova",
                        Type = "RPG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Fabricator",
                        Element = "Any",
                        Location = "Jack's Secret",
                        Name = "ION CANNON",
                        QuestChallengeName = "Jack's Wild",
                        RedText = "Fun Detected: Obliterate.",
                        Summary = "Charging shot releases fast rocket. 6 ammo/shot",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Georgous Armada",
                        Element = "F C S O",
                        Location = "The Compactor",
                        Name = "Heart Breaker",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "I don't want to set the world on fire...",
                        Summary = "Heals you when damaging enemy. Heart shaped projectile pattern",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "DEGEN-3",
                        Element = "F C S R O",
                        Location = "Impound Deluxe",
                        Name = "Slow Hand",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Take your time, sugar...",
                        Summary = "Heals you when damaging enemy. Slow explosive projectiles",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Claptrap Prime",
                        Element = "N F",
                        Location = "The Compactor",
                        Name = "Boomer",
                        QuestChallengeName = "One Man's Treasure",
                        RedText = "Some like it hot.",
                        Summary = "Full-Auto / 5-round burst. 2 ammo/shot. Explosive shots",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Jackpot",
                        Element = "Any",
                        Location = "VIP Tower",
                        Name = "Cheap Tips",
                        QuestChallengeName = "All Bets Off",
                        RedText = "I'll get home early from work.",
                        Summary = "Dmging enemies, 10% chance to drop chips that +10% wpn dmg for 12s",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Evil Saint Lawrence",
                        Element = "F C S R O",
                        Location = "The Spendopticon",
                        Name = "ION LASER",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Particles unite!",
                        Summary = "Continuous beam. Stop firing shoots orbs, count based on beam duration",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Freddie the Traitor",
                        Element = "N F C S",
                        Location = "VIP Tower",
                        Name = "AutoAimè",
                        QuestChallengeName = "All Bets Off",
                        RedText = "OGC HOOKED.",
                        Summary = "Full-Auto / 2-round burst. Shoots homing lasers",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Ember Mail",
                        Element = "F C S",
                        Location = null,
                        Name = "Ember's Purge",
                        QuestChallengeName = "Ember Challenge 100%",
                        RedText = "She's the only one who knows what it is to burn.",
                        Summary = "10% chance to create elemental puddle on enemy impact",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Torgue Mail",
                        Element = "F",
                        Location = null,
                        Name = "Scoville",
                        QuestChallengeName = "Torgue Challenge 100%",
                        RedText = "Put a little pepper on the end of it.",
                        Summary = "High splash radius. 5 ammo/shot",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Atlas",
                        DroppedBy = "Sky Bullies",
                        Element = "N/S",
                        Location = "The Anvil",
                        Name = "Rebel Yell",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "When you charge, yell like Furies.",
                        Summary = "Regular bullets deal normal dmg. Tracker bullets deal shock dmg",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Atlas",
                        DroppedBy = "Judge Hightower",
                        Element = "N",
                        Location = "Lectra City",
                        Name = "Carrier",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "I have arrived.",
                        Summary = "On enemy impact, bullet splits in 2 and homes in on the same enemy",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Atlas",
                        DroppedBy = "Anointed Alpha",
                        Element = "N",
                        Location = "The Anvil",
                        Name = "Linc",
                        QuestChallengeName = "Malevolent Practice",
                        RedText = "Power is pizza.",
                        Summary = "Fast fire rate & bullet speed",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Atlas",
                        DroppedBy = "Warden",
                        Element = "N",
                        Location = "The Anvil",
                        Name = "Freeman",
                        QuestChallengeName = "Hammerlocked",
                        RedText = "The right man in the wrong place can make all the difference in the world.",
                        Summary = "Laser guide your missiles",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Atlas",
                        DroppedBy = "Chonk Stomp",
                        Element = "N",
                        Location = "Floodmoor Basin",
                        Name = "Ruby's Wrath",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "No one can escape.",
                        Summary = "7 rockets that can be homed in using alternative fire: vortex grenade",
                        Type = "RPG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Hot Karl",
                        Element = "F",
                        Location = "Devil's Razor",
                        Name = "Embrace the Pain",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "It hurts, HAHAHAHAHA! IT HURTS!!",
                        Summary = "Chance to light yourself on fire",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Hot Karl",
                        Element = "F",
                        Location = "Devil's Razor",
                        Name = "Pain is Power",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Nobody kills me but ME!",
                        Summary = "Damages player when fired. Light yourself on fire when overheated",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Borman Nates",
                        Element = "F",
                        Location = "Meridian Outskirts",
                        Name = "Sawbar",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Suppressing Fires!!!",
                        Summary = "Bullets split into 3 projectiles",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "N F C O",
                        Location = "Midnight's Cairn",
                        Name = "Zheitsev's Eruption",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Pain and Misery erupt in the Void.",
                        Summary = "Launches homing projectiles when overheating",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Raging Titan",
                        Element = "N F C O",
                        Location = "The Slaughter Shaft",
                        Name = "Zheitsev's Eruption",
                        QuestChallengeName = "The Slaughter Shaft",
                        RedText = "Pain and Misery erupt in the Void.",
                        Summary = "Launches homing projectiles when overheating",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Lavender Crawly",
                        Element = "F C",
                        Location = "The Droughts",
                        Name = "Linoge",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "My name is legion, for we are many",
                        Summary = "Hail of slow ricocheting bullets. 4 ammo/shot",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Heckle/Hyde",
                        Element = "R",
                        Location = "Jakobs Estate",
                        Name = "Pestilence",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Go forth conquering, and to conquer.",
                        Summary = "Releases radiation explosion when broken. High fire rate",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Sylestro",
                        Element = "R",
                        Location = "Tazendeer Ruins",
                        Name = "Pestilence",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Go forth conquering, and to conquer.",
                        Summary = "Releases radiation explosion when broken. High fire rate",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Borman Nates",
                        Element = "N",
                        Location = "Meridian Outskirts",
                        Name = "Psycho Stabber",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Fa fa fa fa, fa fa fa fa fa fa...",
                        Summary = "+125% melee damage",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "COV",
                        DroppedBy = "Skrakk",
                        Element = "F S C",
                        Location = "Ascension Bluff",
                        Name = "SkekSil",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Get back, splithead!",
                        Summary = "Occasionally sends out 2 rockets",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Skrakk",
                        Element = "N C R",
                        Location = "Ascension Bluff",
                        Name = "Barrage",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Quick maths.",
                        Summary = "3-round burst",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Blinding Banshee",
                        Element = "C",
                        Location = "Desolation's Edge",
                        Name = "Breath of the Dying",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "VexHeIEIEIdZodEth",
                        Summary = "Every kill spawns a radial burst of projectiles",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "The Rampager",
                        Element = "Any",
                        Location = "Forgotten Basilica",
                        Name = "Good Juju",
                        QuestChallengeName = "Beneath the Meridian",
                        RedText = "Kinda, sorta wants to end all existence.",
                        Summary = "Refills magazine on kill",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "Any",
                        Location = "Midnight's Cairn",
                        Name = "Good Juju",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Kinda, sorta wants to end all existence.",
                        Summary = "Refills magazine on kill",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Psychobillies",
                        Element = "F C S O",
                        Location = "Ambermire",
                        Name = "Kaos",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Grants the mystical art of exploding smallhands.",
                        Summary = "Enemies explode on death. Explosion matches element",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Power Troopers",
                        Element = "N S R O",
                        Location = "Atlas HQ",
                        Name = "Star Helix",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "The stars are better off without us.",
                        Summary = "Full-Auto / 4-round. Shoots a straight bullet between 2 weaving bullets",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Billy, The Anointed",
                        Element = "N F C S",
                        Location = "Jakobs Estate",
                        Name = "Warlord",
                        QuestChallengeName = "Lair of the Harpy",
                        RedText = "My gun sings for your blood.",
                        Summary = "30% chance to not consume ammo. High fire rate & mag size",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Wick and Warty",
                        Element = "N S",
                        Location = "Lectra City",
                        Name = "AAA",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Hold on! They're lithium!",
                        Summary = "Burst fire. Projectiles form an \"A\" pattern. High elemental chance",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Chupacabratch",
                        Element = "C",
                        Location = "Athenas",
                        Name = "Hornet",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Fear the Swarm!",
                        Summary = "6-round burst. High elemental dmg & splash radius",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Mouthpiece",
                        Element = "F C",
                        Location = "Ascension Bluff",
                        Name = "Nemesis",
                        QuestChallengeName = "Cult Following",
                        RedText = "A righteous infliction of retribution.",
                        Summary = "Semi-Auto / 3-round burst. Deals additional shock dmg",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Rakkman",
                        Element = "N",
                        Location = "Carnivora",
                        Name = "Night Flyer",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I have one rule",
                        Summary = "Burst fire. Variable zoom. Dmg's enemy to 1HP",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Killavolt",
                        Element = "S",
                        Location = "Lectra City",
                        Name = "Shocking 9-Volt",
                        QuestChallengeName = "Kill Killavolt",
                        RedText = "Contact.",
                        Summary = "Burst-fire. Shoots triangle of shock projectiles and a lot of sparks",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Agonizer 9000 & Pain",
                        Element = "N",
                        Location = "Guts of Carnivora",
                        Name = "Crader's EM-P5",
                        QuestChallengeName = "Blood Drive",
                        RedText = "Dust off the beta EMP5.",
                        Summary = "Increases movement speed while holding it. \r\nIncreases accuracy while in the air.",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "N",
                        Location = "Midnight's Cairn",
                        Name = "Crader's EM-P5",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Dust off the beta EMP5.",
                        Summary = "Increases movement speed while holding it. \r\nIncreases accuracy while in the air.",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Jabermogwai\n(Must kill with fire)",
                        Element = "F",
                        Location = "Voracious Canopy",
                        Name = "Hellfire",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "We don't need no... something...",
                        Summary = "Full-Auto. High elemental damage & fire rate. Variable zoom",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Demoskaggons",
                        Element = "F/O",
                        Location = "The Droughts",
                        Name = "Night Hawkin",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Stranger than things.",
                        Summary = "Cryo during the day. Fire at night",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Rakkman",
                        Element = "F/O",
                        Location = "Carnivora",
                        Name = "Night Hawkin",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Stranger than things.",
                        Summary = "Cryo during the day. Fire at night",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Brood Mother",
                        Element = "Any",
                        Location = "The Pyre of Stars",
                        Name = "Ripper",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "They say I'm a doctor now.",
                        Summary = "Bladed. Enemies you melee take increased bullet dmg from ripper",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Alicritious Vanda",
                        Element = "Any",
                        Location = "Cistern of Slaughter",
                        Name = "Ripper",
                        QuestChallengeName = "Cistern of Slaughter",
                        RedText = "They say I'm a doctor now.",
                        Summary = "Bladed. Enemies you melee take increased bullet dmg from ripper",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "One Punch",
                        Element = "N F C S",
                        Location = "Lectra City",
                        Name = "Sleeping Giant",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Infinite path carved with unrivaled skill.",
                        Summary = "Reloading has a chance to grant weapon bonuses",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Power Troopers",
                        Element = "Any",
                        Location = "Atlas HQ",
                        Name = "Vanquisher",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Slide forward into your cave.",
                        Summary = "20% slide speed increase. Doubles fire rate while sliding",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Loot Ghost",
                        Element = "O",
                        Location = "The Heck Hole",
                        Name = "Stalker",
                        QuestChallengeName = "Broken Hearts\nBloody Harvest",
                        RedText = "All that remains is an icy husk.",
                        Summary = "3-round burst. Switch between vertical / horizontal",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DAHL",
                        DroppedBy = "Pheonix",
                        Element = "F O",
                        Location = "The Splinterlands",
                        Name = "Malak's Bane",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Welcome to the end.",
                        Summary = "Semi-Auto ricochet, 2 ammo/shot / Shotgun fireballs, 5 ammo/shot",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Katagawa Ball",
                        Element = "S",
                        Location = "Skywell-27",
                        Name = "Brainstormer",
                        QuestChallengeName = "Space-Laser Tag",
                        RedText = "Let's put our heads together.",
                        Summary = "Vertical row spread. Shocks nearby enemies",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Judge Hightower",
                        Element = "Any",
                        Location = "Lectra City",
                        Name = "Conference Call",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Let's just ping everyone all at once",
                        Summary = "Spawns more projectiles. Same as in BL2",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Handsome Jackie",
                        Element = "N",
                        Location = "Skywell-27",
                        Name = "Face-puncher",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Man your own jackhammer.",
                        Summary = "Shoots your melee dmg",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Loot Ghost",
                        Element = "F C S R O",
                        Location = "The Heck Hole",
                        Name = "Fearmonger",
                        QuestChallengeName = "Broken Hearts\nBloody Harvest",
                        RedText = "I can't control their fear, only my own.",
                        Summary = "Increased pellets per terror level up to 7",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Wick and Warty",
                        Element = "Any",
                        Location = "Lectra City",
                        Name = "Phebert",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Faster than all estimates.",
                        Summary = "2 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Loot-o-Gram",
                        Element = "Any",
                        Location = "Skywell-27",
                        Name = "The Butcher",
                        QuestChallengeName = "Dinklebot",
                        RedText = "Fresh Meat!",
                        Summary = "Fully automatic. Very high fire rate & accuracy",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Raging Titan",
                        Element = "Any",
                        Location = "The Slaughter Shaft",
                        Name = "The Butcher",
                        QuestChallengeName = "The Slaughter Shaft",
                        RedText = "Fresh Meat!",
                        Summary = "Fully automatic. Very high fire rate & accuracy",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Tyreen the Destroyer",
                        Element = "Any",
                        Location = "Destroyer's Rift",
                        Name = "Bitch",
                        QuestChallengeName = "Divine Retribution",
                        RedText = "If you can't handle me at my worst...",
                        Summary = "High accuracy and fire rate",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Katagawa Jr.",
                        Element = "F C S R O",
                        Location = "Atlas HQ",
                        Name = "Crossroad",
                        QuestChallengeName = "Atlas, At Last",
                        RedText = "Open the gate for me.",
                        Summary = "6-round burst. 2 ammo/shot",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Handsome Jackie",
                        Element = "Any",
                        Location = "Skywell-27",
                        Name = "Handsome Jackhammer",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Everyone thinks they are the heroes of their own stories.",
                        Summary = "Reload bounces releasing novas & shooting. HJ voice randomly plays",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Power Troopers",
                        Element = "Any",
                        Location = "Atlas HQ",
                        Name = "Hyperfocus XZ41",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "My line has ended.",
                        Summary = "Front shield reflects bullets back at attackers",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Lavender Crawley",
                        Element = "N F S R",
                        Location = "The Droughts",
                        Name = "Predatory Lending",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Bullets are cheap, but not that cheap.",
                        Summary = "Uses cash instead of ammo. $1/shot Low acc. to $3/shot Max acc.",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Wotan the Invincible",
                        Element = "F C S R O",
                        Location = "Midnight's Cairn",
                        Name = "Redistributor",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Man's reach exceeds his imagination.",
                        Summary = "Every 7th shot is Amped. Amped shots chain to nearby enemies",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Urist McEnforcer",
                        Element = "N",
                        Location = "Lectra City",
                        Name = "Crossbow",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "All craftsdwarfship is of the highest quality.",
                        Summary = "Shoots explosive bolt. One shot mag size",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Captain Traunt",
                        Element = "Any",
                        Location = "Athenas",
                        Name = "Tankman's Shield",
                        QuestChallengeName = "The Impending Storm",
                        RedText = "You ever seen this dude tank anything ever?",
                        Summary = "Every Kill adds damage to the next magazine",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "Any",
                        Location = "Midnight's Cairn",
                        Name = "Tankman's Shield",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "You ever seen this dude tank anything ever?",
                        Summary = "Every Kill adds damage to the next magazine",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Indo Tyrant",
                        Element = "F C S R O",
                        Location = "Floodmoor Basin",
                        Name = "Woodblocker",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "You don't get into woodblocks unless you are ready to f***.",
                        Summary = "4-round burst",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Sir Hammerlock Mail",
                        Element = "N",
                        Location = null,
                        Name = "Bekah",
                        QuestChallengeName = "Hammerlock's Legendary Hunt 100%",
                        RedText = "Shoot them in the face. Twice.",
                        Summary = "Shot splits into 3 projectiles. Hits twice",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Billy, The Anointed",
                        Element = "N",
                        Location = "Jakobs Estate",
                        Name = "Gatling Gun",
                        QuestChallengeName = "Lair of the Harpy",
                        RedText = "Watch me crank it, watch me roll.",
                        Summary = "Fully-Auto. Increases fire rate the longer you shoot. +Crit% bonus",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Quest Reward",
                        Element = "N",
                        Location = "Floodmoor Basin",
                        Name = "Hand of Glory",
                        QuestChallengeName = "The Guns of Reliance",
                        RedText = "By one, by two, by three!",
                        Summary = "2-Round burst",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Billy, The Anointed",
                        Element = "N",
                        Location = "Jakobs Estate",
                        Name = "Lead Sprinkler",
                        QuestChallengeName = "Lair of the Harpy",
                        RedText = "Splish splash.",
                        Summary = "Crit spawns explosive projectile. Ricochets off enemy",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Jabbermogwai",
                        Element = "N",
                        Location = "Voracious Canopy",
                        Name = "Lead Sprinkler",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Splish splash.",
                        Summary = "Crit spawns explosive projectile. Ricochets off enemy",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Red Rain",
                        Element = "F S R",
                        Location = "Slaughterstar 3000",
                        Name = "Rowan's Call",
                        QuestChallengeName = "Slaughterstar 3000",
                        RedText = "Uh-oh!",
                        Summary = "Crit ricochets 2 bullets & returns 2 bullets to mag. Lasers",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Quest Reward",
                        Element = "N",
                        Location = "Devil's Razor",
                        Name = "Amazing Grace",
                        QuestChallengeName = "Life of the Party",
                        RedText = "Memento mori.",
                        Summary = "Crit returns bullet to mag. Low fire rate. High dmg",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Tyreen the Destroyer",
                        Element = "F S\nC R O",
                        Location = "Destroyer's Rift",
                        Name = "King's Call \nQueen's Call",
                        QuestChallengeName = "Divine Retribution",
                        RedText = "Life is ours, we live it our way.",
                        Summary = "Crit ricochets 3 bullets & returns 3 bullets to mag",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Tremendous Rex",
                        Element = "N",
                        Location = "Cistern of Slaughter",
                        Name = "Maggie",
                        QuestChallengeName = "Cistern of Slaughter",
                        RedText = "Monty's wife don't take no guff.",
                        Summary = "6 pellets per shot. Low accuracy",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Hot Karl",
                        Element = "F",
                        Location = "Devil's Razor",
                        Name = "The Companion",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "You can't take the sky from me.",
                        Summary = "Crit ignites enemy. Very High elemental dmg",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "The Rampager",
                        Element = "N",
                        Location = "Forgotten Basilica",
                        Name = "The Duc",
                        QuestChallengeName = "Beneath the Meridian",
                        RedText = "Fire that off to me real quick.",
                        Summary = "Sticky explosive rounds. Crit ricochets 2 bullets to nearest enemy",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Lagromar",
                        Element = "N",
                        Location = "Konrad's Hold",
                        Name = "The Flood",
                        QuestChallengeName = "The Demon in the Dark",
                        RedText = "Take us.",
                        Summary = "Full-Auto. Incredibly fast fire rate",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Indo Tyrant",
                        Element = "N",
                        Location = "Floodmoor Basin",
                        Name = "Unforgiven",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "It's a helluva thing...",
                        Summary = "+432% crit dmg. Unique reload animation",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Warden",
                        Element = "N",
                        Location = "The Anvil",
                        Name = "Wagon Wheel",
                        QuestChallengeName = "Hammerlocked",
                        RedText = "Keep them doggies rollin'.",
                        Summary = "Ricochets 6 bullets off enemy",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Loot-o-Gram",
                        Element = "N",
                        Location = "Skywell-27",
                        Name = "Wagon Wheel",
                        QuestChallengeName = "Dinklebot",
                        RedText = "Keep them doggies rollin'.",
                        Summary = "Ricochets 6 bullets off enemy",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Road Dog",
                        Element = "F",
                        Location = "The Splinterlands",
                        Name = "Hellwalker",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "So, my demons. Your time has come.",
                        Summary = "Guitar riff on pickup & every shot. Star shaped spread. Quick reload",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Handsome Jackie",
                        Element = "N",
                        Location = "Skywell-27",
                        Name = "Nimble Jack",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Jack be nimble, Jack be quick, Jack jump and kill lunatics.",
                        Summary = "Tight spread. 1 shot reload",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "One Punch",
                        Element = "N",
                        Location = "Lectra City",
                        Name = "One Pump Chump",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I swear, that has never happened before.",
                        Summary = "50% chance to not consume ammo",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Hot Karl",
                        Element = "N",
                        Location = "Devil's Razor",
                        Name = "Sledge's Shotgun",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "The Legend Lives (still)",
                        Summary = "High mag size. Fires in bursts. 2 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Dumptruck",
                        Element = "N F S",
                        Location = "The Droughts",
                        Name = "T.K's Wave",
                        QuestChallengeName = "Dump on Dumptruck",
                        RedText = "Ride the wave, dude!",
                        Summary = "Projectiles travel in a wave pattern. Ricochets off surfaces.",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Chonk Stomp",
                        Element = "N",
                        Location = "Floodmoor Basin",
                        Name = "The Garcia",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Rooty Tooty Pointy Shooty",
                        Summary = "High mag size. 2 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Dumptruck",
                        Element = "N",
                        Location = "The Droughts",
                        Name = "The Tidal Wave",
                        QuestChallengeName = "Dump on Dumptruck",
                        RedText = "Flee the wave, dude!",
                        Summary = "Projectiles travel in a tidal wave pattern. Ricochets off surfaces.",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Manvark",
                        Element = "N",
                        Location = "Konrads Hold",
                        Name = "Headsplosion",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "That happens all the time.",
                        Summary = "Shots explode on impact",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "Demoskaggons",
                        Element = "N",
                        Location = "The Droughts",
                        Name = "Monocle",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "One is enough.",
                        Summary = "High +crit dmg bonus while ADS ~500%. High accuracy. High Zoom",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Jakobs",
                        DroppedBy = "100 Broken Hearts",
                        Element = "F/O",
                        Location = null,
                        Name = "Wedding Invitation",
                        QuestChallengeName = "Broken Hearts",
                        RedText = "Will you be the rest of my life?",
                        Summary = "Shoots as fire, ricochets as cryo. Crit returns 1 bullet",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Gigamind",
                        Element = "F/S",
                        Location = "Meridian Metroplex",
                        Name = "Hellshock",
                        QuestChallengeName = "Hostile Takeover",
                        RedText = "I had not thought death had undone so many.",
                        Summary = "2 projectiles/shot. Ricochet switches projectile element",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Deluxe Edition",
                        Element = "S",
                        Location = null,
                        Name = "Hyper-Hydrator",
                        QuestChallengeName = null,
                        RedText = "Moister is noice-ter",
                        Summary = "Water gun / Taser. Wet enemies take increased shock dmg",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Suicide option",
                        Element = "F/C",
                        Location = "Ambermire",
                        Name = "Sellout",
                        QuestChallengeName = "Sellout",
                        RedText = "Hey there, superfan!",
                        Summary = "Quick laser that explodes as an orb on impact. Damages user",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Baron Noggin",
                        Element = "F",
                        Location = "Meridian Metroplex",
                        Name = "Superball",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Flower power.",
                        Summary = "Shoots small fire balls that bounce along the ground",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Power Troopers",
                        Element = "S",
                        Location = "Atlas HQ",
                        Name = "Thunderball Fists",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I can have such a thing?",
                        Summary = "Shock orb. 2 ammo/shot",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Katagawa Ball",
                        Element = "S",
                        Location = "Skywell-27",
                        Name = "Kill-o'-the-Wisp",
                        QuestChallengeName = "Space-Laser Tag",
                        RedText = "Some say it can lead you to your fate.",
                        Summary = "Charge up to shoot a large slow shock orb. 4 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Mouthpiece",
                        Element = "N",
                        Location = "Ascension Bluff",
                        Name = "Mind-Killer",
                        QuestChallengeName = "Cult Following",
                        RedText = "I must not fear. Fear is the mind-killer",
                        Summary = "Can charge up shot.",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "General Traunt",
                        Element = "Any",
                        Location = "Desolation's Edge",
                        Name = "Recursion",
                        QuestChallengeName = "Footsteps of Giants",
                        RedText = "See green text for description | See red text for description",
                        Summary = "Shoots a disk that ricochets off walls",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Private Beans",
                        Element = "Any",
                        Location = "Athenas",
                        Name = "Trevonator",
                        QuestChallengeName = "Invasion of Privacy",
                        RedText = "Trev is gunna get you!",
                        Summary = "Very low charge time. 3-round burst",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Troy Calypso",
                        Element = "F C S R O",
                        Location = "The Great Vault",
                        Name = "Vosk's Deathgrip",
                        QuestChallengeName = "The Great Vault",
                        RedText = "A good death is its own reward.",
                        Summary = "\"Vosk's Grasp\", a singularity shot / 6 shot laser trap",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "F C S R O",
                        Location = "Midnight's Cairn",
                        Name = "Vosk's Deathgrip",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "A good death is its own reward.",
                        Summary = "\"Vosk's Grasp\", a singularity shot / 6 shot laser trap",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Talk to Ava",
                        Element = "C",
                        Location = "Forgotten Basilica",
                        Name = "Cloud Kill",
                        QuestChallengeName = "Beneath the Meridian",
                        RedText = "Now, you will rise.",
                        Summary = "Produces a green cloud. High fire rate",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Borman Nates",
                        Element = "F C S",
                        Location = "Meridian Outskirts",
                        Name = "Cutsman",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Little android man, born without a soul.",
                        Summary = "[Bladed]. 2 ammo/shot",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Power Troopers",
                        Element = "Any",
                        Location = "Atlas HQ",
                        Name = "Destructo Spinner",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I've been hired for destruction.",
                        Summary = "Projectiles spin",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Captain Traunt",
                        Element = "Any",
                        Location = "Athenas",
                        Name = "Devoted",
                        QuestChallengeName = "The Impending Storm",
                        RedText = "This is your champion.",
                        Summary = "Increases fire rate the longer you shoot. High mag size",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Wotan the Invincible",
                        Element = "Any",
                        Location = "Midnight's Cairn",
                        Name = "Kyb's Worth",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Stand in the f****** circle.",
                        Summary = "Fallen enemies spawn a Healing Aura once every 10 seconds",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "50 Hearts",
                        Element = "F/S",
                        Location = null,
                        Name = "Terminal Polyaimorous",
                        QuestChallengeName = "Broken Hearts",
                        RedText = "Spread the love.",
                        Summary = "Shoots a continuous beam. Chains to nearby enemies",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Katagawa Ball",
                        Element = "C/S",
                        Location = "Skywell-27",
                        Name = "Tsunami",
                        QuestChallengeName = "Space-Laser Tag",
                        RedText = "You can't explain that.",
                        Summary = "Fires in alternating diagonal rows of corrosive & shock",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "VIP Insider Reward",
                        Element = "C/S",
                        Location = null,
                        Name = "Vault Hero",
                        QuestChallengeName = null,
                        RedText = "You can't explain that.",
                        Summary = "Fires in alternating diagonal rows of corrosive & shock",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Private Beans",
                        Element = "Any",
                        Location = "Athenas",
                        Name = "Westergun",
                        QuestChallengeName = "Invasion of Privacy",
                        RedText = "I believe ya, but my tommy gun don't.",
                        Summary = "+75 splash radius",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Maxitrillion",
                        Element = "S",
                        Location = "Voracious Canopy",
                        Name = "ASMD",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "You planning a follow up?",
                        Summary = "Energy shots / Orb. Orb explodes when shot with energy bolt",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Katagawa Jr.",
                        Element = "F",
                        Location = "Atlas HQ",
                        Name = "Firestorm",
                        QuestChallengeName = "Atlas, At Last",
                        RedText = "Seek shelter immediately.",
                        Summary = "High splash radius. 2 ammo/shot.",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "The Rampager",
                        Element = "F",
                        Location = "Forgotten Basilica",
                        Name = "Krakatoa",
                        QuestChallengeName = "Beneath the Meridian",
                        RedText = "Get him angry and he's bound to erupt",
                        Summary = "Turns killed enemies into volcanoes (must be on ground). Full-Auto",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Maliwan",
                        DroppedBy = "Katagawa Jr.",
                        Element = "S",
                        Location = "Atlas HQ",
                        Name = "Storm",
                        QuestChallengeName = "Atlas, At Last",
                        RedText = "Tut, Tut, it looks like rain.",
                        Summary = "Shock orb on impact. 2 ammo/shot. High splash radius",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "CL4P-TP Mail",
                        Element = "Any",
                        Location = null,
                        Name = "Baby Maker ++",
                        QuestChallengeName = "Dead Claptrap 100%",
                        RedText = "Safety off.",
                        Summary = "Reload explodes on impact and becomes 4 flying pistols",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Brood Mother",
                        Element = "Any",
                        Location = "The Pyre of Stars",
                        Name = "Baby Maker ++",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Safety off.",
                        Summary = "Reload explodes on impact and becomes 4 flying pistols",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Alacritous Vanda",
                        Element = "Any",
                        Location = "Cistern of Slaughter",
                        Name = "Baby Maker ++",
                        QuestChallengeName = "Cistern of Slaughter",
                        RedText = "Safety off.",
                        Summary = "Reload explodes on impact and becomes 4 flying pistols",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Thunk & Sloth",
                        Element = "Any",
                        Location = "Konrad's Hold",
                        Name = "Bangarang XL",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "To die would be a grand adventure.",
                        Summary = "Reload flies around continuously spinning & shooting rapidly",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Indo Tyrant",
                        Element = "N C S R O",
                        Location = "Floodmoor Basin",
                        Name = "Gunerang XL",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Give it a burl.",
                        Summary = "Reload flies around like a Boomerang",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "General Traunt",
                        Element = "C O",
                        Location = "Desolation's Edge",
                        Name = "S3RV-8OS-Execute+",
                        QuestChallengeName = "Footsteps of Giants",
                        RedText = "Touch of death requires mastery of combo strikes.",
                        Summary = "Reload on empty debuffs enemy for 50% increased dmg for 12 seconds\r\nFast reload throw and velocity",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Wotan the Invincible",
                        Element = "C O",
                        Location = "Midnight's Cairn",
                        Name = "S3RV-8OS-Execute+",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Touch of death requires mastery of combo strikes.",
                        Summary = "Reload on empty debuffs enemy for 50% increased dmg for 12 seconds\r\nFast reload throw and velocity",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Judge Hightower",
                        Element = "N",
                        Location = "Lectra City",
                        Name = "Scorpio XL",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Mobile oppression for pennies a day.",
                        Summary = "Reload creates Roland's turret",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Mother of Grogans",
                        Element = "C",
                        Location = "The Anvil",
                        Name = "Creeping Death",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I creep across the land.",
                        Summary = "Reload creates target for homing grenades the gun shoots",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Maxitrillion",
                        Element = "Any",
                        Location = "Voracious Canopy",
                        Name = "The Horizon",
                        QuestChallengeName = "Rare enemy",
                        RedText = "You can't leave. She wont let you.",
                        Summary = "Reload projects target that can be shot to create a Singularity",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "GenIVIV",
                        Element = "F C S R O",
                        Location = "Voracious Canopy",
                        Name = "Polybius",
                        QuestChallengeName = "The Family Jewel",
                        RedText = "21. 11. 33. 14. 24. 42.",
                        Summary = "Reload becomes a crab turret. Spread forms a square",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Lagromar",
                        Element = "F",
                        Location = "Konrad's Hold",
                        Name = "Long Musket ++",
                        QuestChallengeName = "The Demon in the Dark",
                        RedText = "Say \"cryptocurrency\"!",
                        Summary = "Reload has legs. Flamethrower. Can stick to walls.",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "Gigamind",
                        Element = "C",
                        Location = "Meridian Metroplex",
                        Name = "Smart Gun XXL",
                        QuestChallengeName = "Hostile Takeover",
                        RedText = "Busy getting brain like Krang.",
                        Summary = "Reload becomes a sticky turret",
                        Type = "SMG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Tediore",
                        DroppedBy = "GenIVIV",
                        Element = "Any",
                        Location = "Voracious Canopy",
                        Name = "Ten Gallon",
                        QuestChallengeName = "The Family Jewel",
                        RedText = "Let me tell you about my best friend.",
                        Summary = "Reload becomes a drone. Explode on impact",
                        Type = "SMG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Heckle/Hyde",
                        Element = "F/S",
                        Location = "Jakobs Estate",
                        Name = "Alchemist",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "You can't gain something without giving something in return.",
                        Summary = "Semi-Auto. Sticks as shock, explodes as fire. Damages user",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Heckle/Hyde",
                        Element = "Any",
                        Location = "Jakobs Estate",
                        Name = "Bearcat",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "I love the smell of popcorn in the morning",
                        Summary = "Launches horizontal row of grenades. 4 ammo/shot",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Aurelia Hammerlock",
                        Element = "N O",
                        Location = "Blackbarrel Cellars",
                        Name = "Juliet's Dazzle",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "Lights up the world",
                        Summary = "Killing an enemy automatically refills the magazine.",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "N O",
                        Location = "Midnight's Cairn",
                        Name = "Juliet's Dazzle",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Lights up the world",
                        Summary = "Killing an enemy automatically refills the magazine.",
                        Type = "AR",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Sylestro",
                        Element = "F C S R O",
                        Location = "Tazendeer Ruins",
                        Name = "Laser-Sploder",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "LASERS ≠ EXPLOSIONS!?",
                        Summary = "Constant laser of elemental damage and rockets",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Manvark",
                        Element = "N F C S R",
                        Location = "Konrad's Hold",
                        Name = "Try-Bolt",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Do... or do not-bolt.",
                        Summary = "3 round grenade launcher",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Psychobillies",
                        Element = "Any",
                        Location = "Ambermire",
                        Name = "Breeder",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Man hands on misery to man.",
                        Summary = "Shoots sticky that spawns small mirv grenades",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Unstoppable",
                        Element = "N",
                        Location = "Ambermire",
                        Name = "Devastator",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Hail.",
                        Summary = "2-round burst. +292 splash radius",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Psychobillies",
                        Element = "Any",
                        Location = "Ambermire",
                        Name = "Devils Foursum",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "I love it when a plan comes together.",
                        Summary = "3 explosive shots that come together at a single point",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Deluxe Edition",
                        Element = "N",
                        Location = null,
                        Name = "Girth Blaster Elite",
                        QuestChallengeName = null,
                        RedText = "Don't go to pieces on me.",
                        Summary = "Toy gun that shoots foam darts",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Wotan the Invincible",
                        Element = "Any",
                        Location = "Midnight's Cairn",
                        Name = "Moonfire",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Meet your destiny.",
                        Summary = "Every 3rd shot is a powerful shot",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Troy Calypso",
                        Element = "F",
                        Location = "The Great Vault",
                        Name = "Occultist",
                        QuestChallengeName = "The Great Vault",
                        RedText = "The only way you can control people is to lie to them.",
                        Summary = "Shoots swirling fireballs",
                        Type = "Pistol",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Princess Tarantella II",
                        Element = "C",
                        Location = "The Splinterlands",
                        Name = "Roisen's Thorns",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Where there is pleasure, there is pain.",
                        Summary = "Impact shoots 4 fire rockets and 1 corrosive. Sticky is only corrosive",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Psychobillies",
                        Element = "Any",
                        Location = "Ambermire",
                        Name = "Echo",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Don't make me repeat myself.",
                        Summary = "Sticky shot for delayed explosion",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Princess Tarantella II",
                        Element = "C R",
                        Location = "The Splinterlands",
                        Name = "Hive",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Full of bees.",
                        Summary = "Launches hovering ball that shoots many rockets before exploding",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "[Found in game files]",
                        Element = "R",
                        Location = null,
                        Name = "R.Y.N.A.H.",
                        QuestChallengeName = null,
                        RedText = "You've had this one coming a long time.",
                        Summary = "Launches hovering ball that shoots many rockets before exploding",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Brood Mother",
                        Element = "Any",
                        Location = "The Pyre of Stars",
                        Name = "Scourge",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Or am I?",
                        Summary = "Shoots 1 large rocket with 3 smaller swirling around it. 4 ammo/shot",
                        Type = "RPG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Alacritous Vanda",
                        Element = "Any",
                        Location = "Cistern of Slaughter",
                        Name = "Scourge",
                        QuestChallengeName = "Cistern of Slaughter",
                        RedText = "Or am I?",
                        Summary = "Shoots 1 large rocket with 3 smaller swirling around it. 4 ammo/shot",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "The Rampager",
                        Element = "FCR",
                        Location = "Forgotten Basilica",
                        Name = "Stuffed Quadomizer",
                        QuestChallengeName = "Beneath the Meridian",
                        RedText = "Damn near killed 'em.",
                        Summary = "Shoots 4 Massive Rockets. Alternates elements. 2 ammo/shot",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Chonk Stomp",
                        Element = "N",
                        Location = "Floodmoor Basin",
                        Name = "Tunguska",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Crack the skye.",
                        Summary = "Fires 2 rockets that rise on impact before detonating",
                        Type = "RPG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Manvark",
                        Element = "N F R",
                        Location = "Konrad's Hold",
                        Name = "Flakker",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Flak the world.",
                        Summary = "Explosions everywhere. 5 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Road Dog",
                        Element = "Any",
                        Location = "The Splinterlands",
                        Name = "Redline",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I live my life a quarter mag at a time.",
                        Summary = "Stuck gyrojets increase dmg by 5% each. 2 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Antalope",
                        Element = "Any",
                        Location = "Devil's Razor",
                        Name = "The Boring Gun",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "This is beyond science.",
                        Summary = "Shoots 3 grounded sawblades that dig in fired direction. 2 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Graveward",
                        Element = "F C S R O",
                        Location = "The Floating Tomb",
                        Name = "The Lob",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "Everything has to be magical.",
                        Summary = "3-round burst of big slow orbs that pass through enemies",
                        Type = "Shotgun",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "TORGUE",
                        DroppedBy = "Wotan the Invincible",
                        Element = "F C S R O",
                        Location = "Midnight's Cairn",
                        Name = "Tiggs' Boom",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "A gaping hole in the sky.",
                        Summary = "Shots pierce enemies. Makes meteors fall from the sky. 2 ammo/shot",
                        Type = "Shotgun",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Agonizer 9000",
                        Element = "Any",
                        Location = "Guts of Carnivora",
                        Name = "Damned",
                        QuestChallengeName = "Blood Drive",
                        RedText = "Well, I'll be...",
                        Summary = "Weapon shield",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Raging Titan",
                        Element = "Any",
                        Location = "The Slaughter Shaft",
                        Name = "Engulfing Shredifier",
                        QuestChallengeName = "The Slaughter Shaft",
                        RedText = "Speed Kills.",
                        Summary = "Full-Auto / Random underbarrel attachment. High fire rate & mag size",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Atomic",
                        Element = "Any",
                        Location = "Tazendeer Ruins",
                        Name = "Faisor",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Set Faisors to kill.",
                        Summary = "Full auto / Shotgun",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Loot-o-Gram",
                        Element = "F C O",
                        Location = "Skywell-27",
                        Name = "Lucian's Call",
                        QuestChallengeName = "Dinklebot",
                        RedText = "What happened?",
                        Summary = "Crit returns 2 bullets to mag & ricochets 2 bullets",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Blue Fire",
                        Element = "F C O",
                        Location = "Slaughterstar 3000",
                        Name = "Lucian's Call",
                        QuestChallengeName = "Slaughterstar 3000",
                        RedText = "What happened?",
                        Summary = "Crit returns 2 bullets to mag & ricochets 2 bullets",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Anointed Alpha",
                        Element = "N",
                        Location = "The anvil",
                        Name = "Ogre",
                        QuestChallengeName = "Malevolent Practice",
                        RedText = "It's all ogre now.",
                        Summary = "Shots explode on impact. High magazine size",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Agonizer 9000 & Pain",
                        Element = "Any",
                        Location = "Guts of Carnivora",
                        Name = "The Dictator",
                        QuestChallengeName = "Blood Drive",
                        RedText = "Let them hate me, so that they will but fear me.",
                        Summary = "Full-Auto 3 projectiles / Bipod 7 projectiles. Fires in horizontal spread",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Warden",
                        Element = "Any",
                        Location = "The Anvil",
                        Name = "Sickle",
                        QuestChallengeName = "Hammerlocked",
                        RedText = "Swing the sickle!",
                        Summary = "It's really a Full-Auto shotgun. Spread forms a sickle. 2 ammo/shot",
                        Type = "AR",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Anointed Alpha",
                        Element = "Any",
                        Location = "The anvil",
                        Name = "Infinity",
                        QuestChallengeName = "Malevolent Practice",
                        RedText = "It's closer than you think! (no it isn't)",
                        Summary = "Infinite Ammo. Full-Auto. Spray pattern resembles infinity symbol",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Jabbermogwai",
                        Element = "N F C S",
                        Location = "Voracious Canopy",
                        Name = "Magnificent",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Yedesh na den', khleba beri na nedelyu.",
                        Summary = "Very low accuracy. High fire rate",
                        Type = "Pistol",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Crushjaw",
                        Element = "R",
                        Location = "C. of the Twin Gods",
                        Name = "Jericho",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "I prefer the weapon you only need to fire once.",
                        Summary = "Launcher / Mortar. Explodes into mirv grenades",
                        Type = "RPG",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "[Found in game files]",
                        Element = "F C S R",
                        Location = null,
                        Name = "Mongol",
                        QuestChallengeName = null,
                        RedText = "Man is a horde animal.",
                        Summary = "Launcher / Mortar. Explodes into mirv grenades",
                        Type = "RPG",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Zer0 Mail",
                        Element = "Any",
                        Location = null,
                        Name = "Lyuda",
                        QuestChallengeName = "Target of Opportunity 100%",
                        RedText = "Man killer.",
                        Summary = "Launcher / Mortar. Explodes into mirv grenades",
                        Type = "Sniper",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Vladof",
                        DroppedBy = "Tremendous Rex",
                        Element = "Any",
                        Location = "Cistern of Slaughter",
                        Name = "Lyuda",
                        QuestChallengeName = "Cistern of Slaughter",
                        RedText = "Man killer.",
                        Summary = "Splits into 3 projectiles",
                        Type = "Sniper",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Chupacabratch",
                        Element = "N",
                        Location = "Athenas",
                        Name = "Chupa's Organ",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Cabrón.",
                        Summary = "Sticks to enemy and does damage over time to health. Ignores shields",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Barron Noggin",
                        Element = "S",
                        Location = "Meridian Metroplex",
                        Name = "EMP",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Drop the shields.",
                        Summary = "Depletes enemy shields",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "DJ Deadsk4g",
                        Element = "N F",
                        Location = "The Splinterlands",
                        Name = "Epicenter",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "It burns, burns, burns",
                        Summary = "Explodes twice releasing radial of projectiles.",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Thunk",
                        Element = "Any",
                        Location = "Konrad's Hold",
                        Name = "Fastball",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Forget the curveball Ricky, give him the heater.",
                        Summary = "Throws the grenade like a fast baseball. Explodes on impact",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Captain Traunt",
                        Element = "F",
                        Location = "Athenas",
                        Name = "Firestorm",
                        QuestChallengeName = "The Impending Storm",
                        RedText = "Soon afterwards, the cloud descended upon the earth.",
                        Summary = "Rains fireballs down from the sky",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Loot Ghost",
                        Element = "C",
                        Location = "The Heck Hole",
                        Name = "Ghast Call",
                        QuestChallengeName = "Broken Hearts\nBloody Harvest",
                        RedText = "To you I am past, a story to tell.",
                        Summary = "Throws a ghost which explodes into more ghosts",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sky Bullies",
                        Element = "S R O",
                        Location = "The Anvil",
                        Name = "Hex",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Keeper of the stars, I hope to never find...",
                        Summary = "Hovers around releasing beams of damage to nearby enemies",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "GenIVIV",
                        Element = "Any",
                        Location = "Voracious Canopy",
                        Name = "Hunter-Seeker",
                        QuestChallengeName = "The Family Jewel",
                        RedText = "Grip tightly.",
                        Summary = "Splits into 2 slow drones that shoot before exploding",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sloth & Thunk",
                        Element = "N",
                        Location = "Konrad's Hold",
                        Name = "It's Piss",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Hey you guys!",
                        Summary = "Removes status effects on allies. Damaged enemies take +20% dmg",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Killavolt",
                        Element = "F/S",
                        Location = "Lectra City",
                        Name = "Moxxi's Bouncing Pair",
                        QuestChallengeName = "Kill Killavolt",
                        RedText = "Prepare for trouble, and make it double.",
                        Summary = "Rubberized. Throws 2 grenades at once. Increased dmg every bounce",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Chupacabratch",
                        Element = "N",
                        Location = "Athenas",
                        Name = "Nagata",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Beltalowda!",
                        Summary = "Spawns circle of longbow grenades",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Wick and Warty",
                        Element = "S",
                        Location = "Lectra City",
                        Name = "Quasar",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "E=mc^(OMG)/wtf",
                        Summary = "Hovers & sucks enemies in. Constant arcs of electricity",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Blinding Banshee",
                        Element = "N",
                        Location = "Desolation's Edge",
                        Name = "Red Queen",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "OFF WITH THEIR HEADS!",
                        Summary = "Rubberized. Splits into 2 laser-connected grenades.",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "El Dragon Jr.",
                        Element = "S",
                        Location = "Jakobs Estate",
                        Name = "Storm Front",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Very, very frightening.",
                        Summary = "Splits into 4 grenades that deal continuous shock to nearby enemies",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Power Troopers",
                        Element = "Any",
                        Location = "Atlas HQ",
                        Name = "Surge",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Thar she blows!",
                        Summary = "Rubberized. Releases 3 mirv grenades every bounce",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Raging Titan",
                        Element = "Any",
                        Location = "The Slaughter Shaft",
                        Name = "Tina's Hippity Hopper",
                        QuestChallengeName = "The Slaughter Shaft",
                        RedText = "Hare today, bomb tomorrow.",
                        Summary = "Rubberized. Releases 2 mirv grenades every bounce",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Power Troopers",
                        Element = "Any",
                        Location = "Atlas HQ",
                        Name = "Tran-fusion",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Here go, hell come.",
                        Summary = "Heals for 120% of hp dmg dealt. Heals shields for 30% shield dmg",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Aurelia Hammerlock",
                        Element = "Any",
                        Location = "Blackbarrel Cellars",
                        Name = "Widowmaker",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "À la vie, à la mort.",
                        Summary = "Proximity grenade. Spawns homing rockets",
                        Type = "GrenadeMod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Deluxe Edition",
                        Element = "N",
                        Location = null,
                        Name = "Cheddar Shredder",
                        QuestChallengeName = null,
                        RedText = "Make it rain.",
                        Summary = "\"Enemies drop a holy metric buttload of cash when damaged\"",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Deluxe Edition",
                        Element = "N",
                        Location = null,
                        Name = "Diamond Butt Bomb",
                        QuestChallengeName = null,
                        RedText = "Bye bye, Li'l Butt Stallion!",
                        Summary = "Throw Buttstallion with a rainbow explosion",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Deluxe Edition",
                        Element = "N",
                        Location = null,
                        Name = "Ultraball",
                        QuestChallengeName = null,
                        RedText = "Do not taunt Happy Fun Ball.",
                        Summary = "Explodes into bouncing grenades & bouncy balls",
                        Type = "GrenadeMod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "Any",
                        Location = null,
                        Name = "Old God",
                        QuestChallengeName = null,
                        RedText = "The end comes from within.",
                        Summary = "+20% >element< dmg & +25% elemental resistance",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = null,
                        Element = "F",
                        Location = null,
                        Name = "Torch",
                        QuestChallengeName = null,
                        RedText = "Inflammable means flammable?!",
                        Summary = "Shoot fireballs around the player on depletion that deal 10195 dmg (lvl 57)",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Empowered Scholar",
                        Element = "O",
                        Location = "Dustbound Archives",
                        Name = "Void Rift",
                        QuestChallengeName = "Case of Wainwright",
                        RedText = "Be careful what comes out.",
                        Summary = "Fires homing spikes at enemies when taking bullet dmg",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Empowered Grawn",
                        Element = null,
                        Location = "Negul Neshai",
                        Name = "Lunacy",
                        QuestChallengeName = "Mountain of Mayhem",
                        RedText = "Equivalent Exchange",
                        Summary = "Double your shield's capacity but greatly increases recharge delay",
                        Type = "Artifact",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC2",
                        DroppedBy = "Quest Reward",
                        Element = null,
                        Location = "The Lodge",
                        Name = "The Pearl of Ineffable Knowledge",
                        QuestChallengeName = "The Call of Gythian",
                        RedText = "Knowing is half the battle.",
                        Summary = "Consec. hits +1% dmg per hit up to 15 times. At max, add  +20% dmg",
                        Type = "Artifact",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "DLC1",
                        DroppedBy = "Quest Reward",
                        Element = "N",
                        Location = "VIP Tower",
                        Name = "Rico",
                        QuestChallengeName = "All Bets Off",
                        RedText = "You wanna live forever?",
                        Summary = "50% chance to reflect shots while shielded. 80% while not shielded",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Deluxe Edition",
                        Element = "N",
                        Location = null,
                        Name = "Badass Combustor",
                        QuestChallengeName = null,
                        RedText = "Take it up to eleven!",
                        Summary = "Nova. Exp boost +10% & Loot Rarity Boost through lvl 10",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Aurelia Hammerlock",
                        Element = "O",
                        Location = "Blackbarrel Cellars",
                        Name = "Frozen Heart",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "I feel... cold.",
                        Summary = "Nova 30% of nova dmg returned as HP",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Valkyrie Squad / Wotan",
                        Element = "Any",
                        Location = "Midnight's Cairn",
                        Name = "Version 0.m",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Stand and Clap.",
                        Summary = "Amp: ~125% bonus dmg. Spawns buff circle on shield break for 5 sec",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "GenIVIV",
                        Element = "N C S",
                        Location = "Voracious Canopy",
                        Name = "Messy Breakup",
                        QuestChallengeName = "The Family Jewel",
                        RedText = "It's complicated.",
                        Summary = "Gives you a drone. Drone dmg is same as element resist",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Power Troopers",
                        Element = "F",
                        Location = "Atlas HQ",
                        Name = "Nova Berner",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Feel the Bern.",
                        Summary = "Nova on depletion and fill",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Gigamind",
                        Element = "N C S R O",
                        Location = "Meridian Metroplex",
                        Name = "Red Card",
                        QuestChallengeName = "Hostile Takeover",
                        RedText = "All studs.",
                        Summary = "Sliding drains all shield to deal bonus dmg",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Valkyrie Squad",
                        Element = "F C S R",
                        Location = "Midnight's Cairn",
                        Name = "Red Card Re-Charger",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "One more kick, with feeling",
                        Summary = null,
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Princess Tarantella II",
                        Element = "N F C R",
                        Location = "The Splinterlands",
                        Name = "Re-Router",
                        QuestChallengeName = "Rare Enemy",
                        RedText = null,
                        Summary = "Amp. Next shot drains 50% shield. dmg returned as HP",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Troy Calypso",
                        Element = "N",
                        Location = "The Great Vault",
                        Name = "Resonant Back Ham",
                        QuestChallengeName = "The Great Vault",
                        RedText = "Synthetic Vercuvian ham. Typhon DeLeon approved.",
                        Summary = "Damage taken from behind is reduced by 56%",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Urist McEnforcer",
                        Element = "Any",
                        Location = "Lectra City",
                        Name = "Rough Rider",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "It takes more than that to kill a Bull Moose.",
                        Summary = "No capacity. Reduces incoming dmg by 23% & grants +35% Max HP",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Loot Ghost",
                        Element = "O",
                        Location = "The Heck Hole",
                        Name = "Scream of Terror",
                        QuestChallengeName = "Broken Hearts\nBloody Harvest",
                        RedText = "Behold the flesh and power it holds.",
                        Summary = "\"Let loose a piercing scream\" 14872 nova dmg on shield break.",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Valkyrie Squad",
                        Element = "O",
                        Location = "Midnight's Cairn",
                        Name = "Snowshoe",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Give em' the cold toelder.",
                        Summary = "Sliding into enemies drains all shields & deals up to 5949 bonus cryo",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Anshin",
                        DroppedBy = "Crushjaw",
                        Element = "N C S",
                        Location = "C. of the Twin Gods",
                        Name = "Whiskey Tango Foxtrot",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Situation normal.",
                        Summary = "Nova. 25% chance to drop IEDs when damaged",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "Wick and Warty",
                        Element = "N S",
                        Location = "Lectra City",
                        Name = "Black Hole",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "She's gone from suck to blow.",
                        Summary = "Nova & Black Hole (Pulls enemies in)",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "The Unstoppable",
                        Element = "F C S R O",
                        Location = "Ambermire",
                        Name = "Band of Sitorak",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "I said \"biiiiiiiiiiiitttccchhhh...\"",
                        Summary = "+22% wpn dmg while depleted. Low capacity, Very high recharge rate",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "The Unstoppable",
                        Element = "Any",
                        Location = "Ambermire",
                        Name = "Big Boom Blaster",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "For all your big boom blasting needs!",
                        Summary = "boosters restore 60% shield, grenade, & heavy ammo. 15% absorb",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "Antalope",
                        Element = "C",
                        Location = "Devil's Razor",
                        Name = "Impaler",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Out for a walk, bitch.",
                        Summary = "Spike. Fires homing spikes to attackers when taking bullet dmg",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "Quest Reward",
                        Element = "R",
                        Location = "Sandblast Scar",
                        Name = "Red Suit",
                        QuestChallengeName = "A. & S. Demons",
                        RedText = "Warning. Containment failure.",
                        Summary = "100% Radiation resistance. Nearby enemies take constant rad dmg",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "Atomic",
                        Element = null,
                        Location = "Tazendeer Ruins",
                        Name = "Red Suit",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Warning. Containment failure.",
                        Summary = "100% Radiation resistance. Nearby enemies take constant rad dmg",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Pangolin",
                        DroppedBy = "Sky Bully",
                        Element = "Any",
                        Location = "The Anvil",
                        Name = "Shooting Star",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Don't look up.",
                        Summary = "While depleted, successful melee summons a projectile",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Private Beans",
                        Element = "N C R O",
                        Location = "Athenas",
                        Name = "Front Loader",
                        QuestChallengeName = "Invasion of Privacy",
                        RedText = "You could always use a little more life insurance.",
                        Summary = "Reserves 60% max hp returned as shield capacity",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Urist McEnforcer",
                        Element = "Any",
                        Location = "Lectra City",
                        Name = "Re-Charger",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Once more, with feeling.",
                        Summary = "Instant recharging with cooldown. Absorbs ammo. Fortify drop chance",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Valkyrie Squad",
                        Element = "F C R",
                        Location = "Midnight's Cairn",
                        Name = "Re-Charge Berner",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Feelin' the Bern.",
                        Summary = "16730 dmg on break & fill. Instant recharge when broken 20s cooldown",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Sylestro",
                        Element = "S",
                        Location = "Tazendeer Ruins",
                        Name = "Rectifier",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "You conduit.",
                        Summary = "Shocks nearby enemies while depleted",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "El Dragon Jr.",
                        Element = "Any",
                        Location = "Jakobs Estate",
                        Name = "Stop-Gap",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "The process is called \"living\".",
                        Summary = "Immune to dmg on depletion for 5 seconds",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Quest Reward",
                        Element = "S",
                        Location = "Desolation's Edge",
                        Name = "The Transformer",
                        QuestChallengeName = "It's Alive",
                        RedText = "There's more than your eye can see.",
                        Summary = "100% Shock resistance. 40% chance to absorb bullets",
                        Type = "Shield",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Killavolt",
                        Element = null,
                        Location = "Lectra City",
                        Name = "The Transformer",
                        QuestChallengeName = "Kill Killavolt",
                        RedText = "There's more than your eye can see.",
                        Summary = "100% Shock resistance. 40% chance to absorb bullets",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Hyperion",
                        DroppedBy = "Graveward",
                        Element = "Any",
                        Location = "The Floating Tomb",
                        Name = "Ward",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "Free me master, see me shiver",
                        Summary = "+25% weapon dmg, +300% melee dmg depleted. +2%hp/sec active",
                        Type = "Shield",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "General Traunt",
                        Element = "Any",
                        Location = "Desolation's Edge",
                        Name = "Cosmic Crater",
                        QuestChallengeName = "Footsteps of Giants",
                        RedText = "Come on and SLAM!",
                        Summary = "Slam creates a random elemental puddle that lasts for 5 seconds",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Phoenix",
                        Element = "Any",
                        Location = "The Splinterlands",
                        Name = "Deathless",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "What do we say to the God of Death?",
                        Summary = "Reserves all but 1 hp. +100% shield cap. +25% r rate. -20% r delay",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Psychobillies",
                        Element = null,
                        Location = "Ambermire",
                        Name = "Electric Banjo",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "We never could have foreseen the success.",
                        Summary = "20% bullet proc chance",
                        Type = "Artifact",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Graveward",
                        Element = null,
                        Location = "The Floating Tomb",
                        Name = "Grave",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "Pain becomes power.",
                        Summary = "+melee < 50% HP. +weapon dmg < 20% HP. +splash dmg < 5% HP",
                        Type = "Artifact",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Red Rain",
                        Element = "Any",
                        Location = "Slaughterstar 3000",
                        Name = "Launch Pad",
                        QuestChallengeName = "Slaughterstar 3000",
                        RedText = "Pocket Rockets.",
                        Summary = "Slam Launches a barrage of homing rockets",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Agonizer 9000 & Pain",
                        Element = "Any",
                        Location = "Guts of Carnivora",
                        Name = "Loaded Dice",
                        QuestChallengeName = "Blood Drive",
                        RedText = "Feelin' Lucky?",
                        Summary = "-75% Max HP. Increases your Luck.",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Graveward",
                        Element = "Any",
                        Location = "The Floating Tomb",
                        Name = "Moxxi's Endowment",
                        QuestChallengeName = "Cold as the Grave",
                        RedText = "Hey, sugar. I got somethin' for ya",
                        Summary = "+9% Combat XP (lvl 53)",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Tyreen the Destroyer",
                        Element = "Any",
                        Location = "Destroyer's Rift",
                        Name = "Otto Idol",
                        QuestChallengeName = "Divine Retribution",
                        RedText = "Every man for himself.",
                        Summary = "Restores +13% max hp after killing an enemy",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Phoenix",
                        Element = null,
                        Location = "The Splinterlands",
                        Name = "Phoenix Tears",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Rise from the ashes.",
                        Summary = "Gain 100% Health on second wind",
                        Type = "Artifact",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Atomic",
                        Element = "Any",
                        Location = "Tazendeer Ruins",
                        Name = "Planetoid",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "The power is YOURS!",
                        Summary = "+67% elemental melee damage. Element type changes every 5 sec",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "DJ Deadsk4g",
                        Element = "N S R O",
                        Location = "The Splinterlands",
                        Name = "Pull Out Method",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Doesn't work how you think it does...",
                        Summary = "Slam generates a singularity effect, pulling enemies toward you.",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Blue Fire",
                        Element = "Any",
                        Location = "Slaughterstar 3000",
                        Name = "Rocket Boots",
                        QuestChallengeName = "Slaughterstar 3000",
                        RedText = "Not that kind.",
                        Summary = "Slide launches homing rockets that deal incendiary dmg",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Rakkman",
                        Element = "Any",
                        Location = "Carnivora",
                        Name = "Safeguard",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "My own little bubble.",
                        Summary = "Slam triggers a shield that reduces dmg taken by +57%. Lasts 5 sec",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Road Dog",
                        Element = "Any",
                        Location = "The Splinterlands",
                        Name = "Splatter Gun",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "This Is My BOOMSTICK!",
                        Summary = "+50% Shotgun Damage while Sliding",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Antalope",
                        Element = "Any",
                        Location = "Devil's Razor",
                        Name = "Static Charge",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Shock me like an electric eel.",
                        Summary = "Slide builds up static for next melee to deal 50% bonus shock dmg",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "El Dragon Jr.",
                        Element = null,
                        Location = "Jakobs Estate",
                        Name = "Unleash the Dragon",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "En fuego!",
                        Summary = "Melee, slide, & ground slam have 100% chance to ignite enemy",
                        Type = "Artifact",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Sloth",
                        Element = "Any",
                        Location = "Konrad's Hold",
                        Name = "Victory Rush",
                        QuestChallengeName = "Rare Enemy",
                        RedText = "Another one.",
                        Summary = "+18% movement speed and dmg on badass kill for 60 seconds",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = "Eridian",
                        DroppedBy = "Agonizer 9000 & Terror",
                        Element = "Any",
                        Location = "Guts of Carnivora",
                        Name = "White Elephant",
                        QuestChallengeName = "Blood Drive",
                        RedText = "It's a SURPRISE!",
                        Summary = "Melee attacks have a 30% chance to attach a sticky bomb",
                        Type = "Artifact",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = null,
                        Element = "None",
                        Location = null,
                        Name = "Stone",
                        QuestChallengeName = null,
                        RedText = "She's mighty mighty.",
                        Summary = "When hurt, +10% chance to gain Rush stack. +3% dmg reduction/stack",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = null,
                        Element = "None",
                        Location = null,
                        Name = "Tr4iner",
                        QuestChallengeName = null,
                        RedText = "This is my cause.",
                        Summary = "25% chance for pet to confuse enemy for 20 sec instead of kill",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = null,
                        Element = "None",
                        Location = null,
                        Name = "Fleek Sapper",
                        QuestChallengeName = null,
                        RedText = "To each according to their needs.",
                        Summary = "Gain up to 12% Life Steal. Longer fire duration, greater the lifesteal",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = null,
                        Element = "None",
                        Location = null,
                        Name = "Conductor",
                        QuestChallengeName = null,
                        RedText = "Half a league onward.",
                        Summary = "Gain up to 25% bonus shock dmg based on remaining AS duration",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Jackpot",
                        Element = "None",
                        Location = "VIP Tower",
                        Name = "Golden Rule",
                        QuestChallengeName = "All Bets Off",
                        RedText = "I can do this all day.",
                        Summary = "Increases Action skill cooldown rate [5%] for 8s when taking damage",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Jackpot",
                        Element = "None",
                        Location = "VIP Tower",
                        Name = "St4ckbot",
                        QuestChallengeName = "All Bets Off",
                        RedText = "If you can make God bleed, people will cease to believe in them.",
                        Summary = "On critical hit, gain +5% wpn dmg until miss on crit. Effect stacks",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Jackpot",
                        Element = "None",
                        Location = "VIP Tower",
                        Name = "Green Monster",
                        QuestChallengeName = "All Bets Off",
                        RedText = "We often smilin' at sights of violence.",
                        Summary = "Bonus corrosive dmg to weapons after firing for a few seconds",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Jackpot",
                        Element = "None",
                        Location = "VIP Tower",
                        Name = "Seein' Dead",
                        QuestChallengeName = "All Bets Off",
                        RedText = "Musha rain dum a doo, dum a da.",
                        Summary = "4% chance to auto activate all kill skills on wpn dmg. +25% Kill skill effect",
                        Type = "Class Mod",
                        WorldDrop = "Yes"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Skag of Survival",
                        Element = "None",
                        Location = "Gradient of Dawn",
                        Name = "Breaker",
                        QuestChallengeName = "Trial of Survival",
                        RedText = "The closer we are to danger, the further we are from harm.",
                        Summary = "Up to 29% dmg reduction while close to enemy",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tink of Cunning",
                        Element = "None",
                        Location = "Ghostlight Beacon",
                        Name = "Dragon",
                        QuestChallengeName = "Trial of Cunning",
                        RedText = "Fatality.",
                        Summary = "Melee kill triggers Amara's action skill augment",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sera of Supremacy",
                        Element = "None",
                        Location = "Hall Obsidian",
                        Name = "Elementalist",
                        QuestChallengeName = "Trial of Supremacy",
                        RedText = "Firmly grasp it.",
                        Summary = "Phasegrasp applies Action Skill Element to nearby enemies",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sera of Supremacy",
                        Element = "None",
                        Location = "Hall Obsidian",
                        Name = "Nimbus",
                        QuestChallengeName = "Trial of Supremacy",
                        RedText = "It's a terrible day for rain.",
                        Summary = "First dmg from Action Skill creates cloud of Action Skill Element",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Hag of Fervor",
                        Element = "None",
                        Location = "Skydrowned Pulpit",
                        Name = "Phasezerker",
                        QuestChallengeName = "Trial of Fervor",
                        RedText = "I'm always angry.",
                        Summary = "On action skill, gain max Rush stacks, but decay over time.",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sylestro",
                        Element = "None",
                        Location = "Tazendeer Ruins",
                        Name = "Spiritual Driver",
                        QuestChallengeName = "Crew Challenge",
                        RedText = "Only on the brink can we see so clearly.",
                        Summary = "On Action skill, apply skill element to self. + Gun dmg while moving",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Wotan the Invincible",
                        Element = "None",
                        Location = "Midnight's Cairn",
                        Name = "Spiritual Driver",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Only on the brink can we see so clearly.",
                        Summary = "On Action skill, apply skill element to self. + Gun dmg while moving",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tyrant of Instinct",
                        Element = "None",
                        Location = "Wayward Tether",
                        Name = "Cosmic Stalker",
                        QuestChallengeName = "Trial of Instinct",
                        RedText = "Like a bird from the snare of the fowler...",
                        Summary = "FL4K's Hunt Skill Power is increased by 25%",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Hag of Fervor",
                        Element = "None",
                        Location = "Skydrowned Pulpit",
                        Name = "Bounty Hunter",
                        QuestChallengeName = "Trial of Fervor",
                        RedText = "The world is made up of two classes — the hunters and the huntees.",
                        Summary = "3% Hunt Kill Skill chance / Bosses as regular enemies",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tink of Cunning",
                        Element = "None",
                        Location = "Ghostlight Beacon",
                        Name = "DE4DEYE",
                        QuestChallengeName = "Trial of Cunning",
                        RedText = "Cut them down to size.",
                        Summary = "FL4K & their pets deal +35% dmg against enemies above 75% hp",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Arbalest of Discipline",
                        Element = "None",
                        Location = "Precipice Anchor",
                        Name = "Friend-Bot",
                        QuestChallengeName = "Trial of Discipline",
                        RedText = "Don't worry, the dog lives.",
                        Summary = "On enemy kill pet gains Second Wind. Pet dmg +20%",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tink of Cunning",
                        Element = "None",
                        Location = "Ghostlight Beacon",
                        Name = "R4kk P4k",
                        QuestChallengeName = "Trial of Cunning",
                        RedText = "Hail and well met!",
                        Summary = "Whenever Fl4k's Rakk hits an enemy, they split into two more Rakk that seek out enemies",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Wotan the Invincible",
                        Element = "None",
                        Location = "Midnight's Cairn",
                        Name = "R4kk P4k",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Hail and well met!",
                        Summary = "Whenever Fl4k's Rakk hits an enemy, they split into two more Rakk that seek out enemies",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sera of Supremacy",
                        Element = "None",
                        Location = "Hall Obsidian",
                        Name = "Rakk Commander",
                        QuestChallengeName = "Trial of Supremacy",
                        RedText = "Get ready to rakk.",
                        Summary = "Rakk Attack! gains 1 extra charge",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tyrant of Instinct",
                        Element = "None",
                        Location = "Wayward Tether",
                        Name = "Red Fang",
                        QuestChallengeName = "Trial of Instinct",
                        RedText = "Mean and green.",
                        Summary = "While Gamma Burst is active, FL4K's pet taunts all enemies",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tyrant of Instinct",
                        Element = "None",
                        Location = "Wayward Tether",
                        Name = "Bear Trooper",
                        QuestChallengeName = "Trial of Instinct",
                        RedText = "Rocket 'til the wheels fall off.",
                        Summary = "Decreases fuel use, increases Iron Bear's duration",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Arbalest of Discipline",
                        Element = "None",
                        Location = "Precipice Anchor",
                        Name = "Blast Master",
                        QuestChallengeName = "Trial of Discipline",
                        RedText = "Slow and steady wins the arms race.",
                        Summary = "The longer going without reloading, the more splash dmg Moze deals",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Skag of Survival",
                        Element = "None",
                        Location = "Gradient of Dawn",
                        Name = "Bloodletter",
                        QuestChallengeName = "Trial of Survival",
                        RedText = "Ideas are bulletproof.",
                        Summary = "If moze is healed, she gains shields instead",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tink of Cunning",
                        Element = "None",
                        Location = "Ghostlight Beacon",
                        Name = "Mind Sweeper",
                        QuestChallengeName = "Trial of Cunning",
                        RedText = "Brain blast!",
                        Summary = "Crit hit has 25% chance to drop Micro grenade that explodes",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Billy, The Anointed",
                        Element = "None",
                        Location = "Jakobs Estate",
                        Name = "Raging Bear",
                        QuestChallengeName = "Lair of the Harpy",
                        RedText = "You won't just be strong. You'll be unbeatable.",
                        Summary = "Whenever IB kills an enemy, it gains decreased Fuel Usage.\nWhenever IB takes damage, it gains increased Damage.",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Wotan the Invincible",
                        Element = "None",
                        Location = "Midnight's Cairn",
                        Name = "Raging Bear",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "You won't just be strong. You'll be unbeatable.",
                        Summary = "Whenever IB kills an enemy, it gains decreased Fuel Usage.\nWhenever IB takes damage, it gains increased Damage.",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Arbalest of Discipline",
                        Element = "None",
                        Location = "Ghostlight Beacon",
                        Name = "Rocketeer",
                        QuestChallengeName = "Trial of Discipline",
                        RedText = "Chew 'em up!",
                        Summary = "Auto bear lasts remaining duration. Removes refunded cooldown",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Arbelest of Discipline",
                        Element = "None",
                        Location = "Precipice Anchor",
                        Name = "Antifreeze",
                        QuestChallengeName = "Trial of Discipline",
                        RedText = "Jet propulsion disengage.",
                        Summary = "While sliding or airborne, gain +40% wpn dmg and +20% dmg reduction",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Wotan the Invincible",
                        Element = "None",
                        Location = "Midnight's Cairn",
                        Name = "Antifreeze",
                        QuestChallengeName = "Maliwan Takedown",
                        RedText = "Jet propulsion disengage.",
                        Summary = "While sliding or airborne, gain +40% wpn dmg and +20% dmg reduction",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Sera of Supremacy",
                        Element = "None",
                        Location = "Hall Obsidian",
                        Name = "Cold Warrior",
                        QuestChallengeName = "Trial of Supremacy",
                        RedText = "A song of ice and radiation and acid and lightning and fire",
                        Summary = "Random Status Effect applied to enemies Zane freezes",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Skag of Survival",
                        Element = "None",
                        Location = "Gradient of Dawn",
                        Name = "Executor",
                        QuestChallengeName = "Trial of Survival",
                        RedText = "Have a plan to kill everyone you meet.",
                        Summary = "Kill skill: On kill +Accuracy, Handling, Crit, Status Effect dmg & chance",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Tyrant of Instinct",
                        Element = "None",
                        Location = "Wayward Tether",
                        Name = "Infiltrator",
                        QuestChallengeName = "Trial of Instinct",
                        RedText = "When the leaves hang trembling, the wind is passing through.",
                        Summary = "Weapon dmg & shield increase. Higher bonus with low shield",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Hag of Fervor",
                        Element = "None",
                        Location = "Skydrowned Pulpit",
                        Name = "Shockerator",
                        QuestChallengeName = "Trial of Fervor",
                        RedText = "There's a spark between us, can you feel it?",
                        Summary = "+Binary System augment. Shock Nova on getting meleed",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    },

                    new Item
                    {
                        Brand = null,
                        DroppedBy = "Arbalest of Discipline",
                        Element = "None",
                        Location = "Precipice Anchor",
                        Name = "Techspert",
                        QuestChallengeName = "Trial of Discipline",
                        RedText = "If you love something, set it free.",
                        Summary = "Kill skill: +5% chance on kill to recharge SNTNL cooldown & duration",
                        Type = "Class Mod",
                        WorldDrop = "No"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}