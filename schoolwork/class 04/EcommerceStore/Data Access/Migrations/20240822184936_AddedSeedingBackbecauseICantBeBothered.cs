using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access.Migrations
{
    public partial class AddedSeedingBackbecauseICantBeBothered : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModiefiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3472), "A wearable device that combines fitness tracking, smartphone notifications, and various apps in a compact form.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3501), "Smartwatch" },
                    { 2, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3510), "Compact, wireless in-ear headphones offering high-quality audio and noise cancellation features.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3512), "Wireless Earbuds" },
                    { 3, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3514), "High-performance portable computer optimized for gaming, featuring powerful processors, GPUs, and high refresh rate displays.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3516), "Gaming Laptop" },
                    { 4, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3518), "A display screen offering ultra-high-definition resolution for sharper, more detailed visuals in gaming, work, or media.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3520), "4K Monitor" },
                    { 5, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3523), "A head-mounted device that immerses users in a 3D virtual environment for gaming, simulations, and entertainment.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3524), "Virtual Reality Headset" },
                    { 6, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3529), "A portable solid-state drive offering fast data transfer speeds and robust storage for files, games, and media.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3530), "External SSD" },
                    { 7, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3532), "A central device that connects and controls various smart home products like lights, thermostats, and security systems.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3534), "Smart Home Hub" },
                    { 8, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3536), "A wireless speaker that connects to devices via Bluetooth, providing portable, high-quality sound for music and calls.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3538), "Bluetooth Speaker" },
                    { 9, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3540), "An unmanned aerial vehicle equipped with a high-resolution camera for capturing aerial photos and videos.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3541), "Drone with Camera" },
                    { 10, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3544), "A programmable thermostat that adjusts heating and cooling based on user preferences and can be controlled remotely.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3546), "Smart Thermostat" },
                    { 11, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3548), "A portable device designed for reading digital books and magazines, featuring a paper-like display and long battery life.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3550), "E-Reader" },
                    { 12, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3552), "A device that charges smartphones and other gadgets wirelessly through inductive charging technology.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3553), "Wireless Charging Pad" },
                    { 13, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3555), "A wearable device that monitors physical activity, heart rate, sleep patterns, and other health metrics.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3557), "Fitness Tracker" },
                    { 14, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3559), "A surveillance camera system that provides real-time monitoring and alerts to enhance home security.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3561), "Home Security Camera" },
                    { 15, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3563), "Headphones that reduce ambient noise, providing an immersive audio experience for music and calls.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3564), "Noise-Cancelling Headphones" },
                    { 16, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3566), "An energy-efficient light bulb that can be controlled remotely, with options for color and brightness adjustments.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3568), "Smart Light Bulb" },
                    { 17, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3570), "A compact, rechargeable battery pack used to charge smartphones, tablets, and other devices on the go.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3572), "Portable Power Bank" },
                    { 18, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3575), "An autonomous vacuum cleaner that navigates and cleans floors with minimal user input.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3576), "Robot Vacuum Cleaner" },
                    { 19, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3578), "A machine that creates three-dimensional objects by layering material based on digital models.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3580), "3D Printer" },
                    { 20, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3582), "A doorbell with an integrated camera that allows users to see and communicate with visitors remotely.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3584), "Smart Doorbell" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ImageUrl", "ModiefiedBy", "ModifiedOn", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3613), "The latest smartwatch with advanced fitness tracking and seamless iPhone integration.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3615), "Apple Watch Series 7", 399.99m, 18 },
                    { 2, 2, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3630), "Premium wireless earbuds with industry-leading noise cancellation.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3631), "Sony WF-1000XM4", 279.99m, 66 },
                    { 3, 3, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3634), "A powerful gaming laptop with AMD Ryzen 9 processor and RTX 3060 graphics.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3636), "ASUS ROG Zephyrus G14", 1499.99m, 23 },
                    { 4, 4, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3639), "A 27-inch monitor with stunning 4K resolution and ultra-thin bezels.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3640), "Dell UltraSharp 27 4K Monitor", 699.99m, 28 },
                    { 5, 5, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3643), "A standalone VR headset offering an immersive gaming experience without needing a PC.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3645), "Oculus Quest 2", 299.99m, 94 },
                    { 6, 6, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3649), "A fast and durable external SSD with up to 1TB of storage.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3650), "Samsung T7 Portable SSD", 169.99m, 15 },
                    { 7, 7, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3653), "A smart display that connects and controls your smart home devices with a rotating screen.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3655), "Amazon Echo Show 10", 249.99m, 14 },
                    { 8, 8, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3658), "A waterproof Bluetooth speaker offering powerful sound in a portable form.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3659), "JBL Flip 5", 119.99m, 95 },
                    { 9, 9, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3662), "A compact drone with a 4K camera and intelligent flight modes.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3664), "DJI Mavic Air 2", 799.99m, 95 },
                    { 10, 10, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3668), "A smart thermostat that learns your schedule and programs itself to save energy.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3669), "Nest Learning Thermostat", 249.99m, 3 },
                    { 11, 11, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3672), "An e-reader with a high-resolution display and built-in adjustable light.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3674), "Kindle Paperwhite", 129.99m, 27 },
                    { 12, 12, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3677), "A sleek and efficient wireless charger compatible with Qi-enabled devices.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3678), "Anker Wireless Charging Pad", 29.99m, 85 },
                    { 13, 13, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3681), "An advanced fitness tracker with built-in GPS, heart rate monitoring, and stress management tools.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3683), "Fitbit Charge 5", 179.99m, 28 },
                    { 14, 14, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3686), "A wire-free security camera with 2K video resolution and color night vision.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3687), "Arlo Pro 4 Security Camera", 199.99m, 94 },
                    { 15, 15, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3690), "Over-ear headphones with exceptional noise cancellation and premium sound quality.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3692), "Bose QuietComfort 45", 329.99m, 1 },
                    { 16, 16, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3695), "A color-changing smart light bulb that can be controlled via app or voice commands.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3696), "Philips Hue Smart Bulb", 49.99m, 23 },
                    { 17, 17, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3699), "A compact and powerful power bank capable of charging your devices multiple times.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3700), "Anker PowerCore 10000", 39.99m, 98 },
                    { 18, 18, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3704), "A smart vacuum cleaner that empties itself and can be scheduled for automatic cleaning.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3706), "iRobot Roomba i7+", 599.99m, 90 },
                    { 19, 19, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3709), "An affordable and reliable 3D printer for beginners and hobbyists.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3711), "Creality Ender 3 V2", 259.99m, 79 },
                    { 20, 20, 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3714), "A video doorbell with 3D motion detection and enhanced video quality.", "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3715), "Ring Video Doorbell Pro 2", 249.99m, 62 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "ImageUrl", "ModiefiedBy", "ModifiedOn", "ProductId", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { 1, "The Apple Watch Series 7 has been a game-changer for tracking my workouts.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3744), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3746), 1, 5, "John Doe" },
                    { 2, "The noise cancellation on the Sony WF-1000XM4 is amazing. Perfect for commuting!", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3752), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3754), 2, 1, "Jane Smith" },
                    { 3, "The ASUS ROG Zephyrus G14 runs all my games smoothly. Best gaming laptop I've owned!", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3757), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3758), 3, 5, "Alex Johnson" },
                    { 4, "The Dell UltraSharp 27 4K Monitor has stunning visuals, perfect for my design work.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3761), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3762), 4, 4, "Emily Brown" },
                    { 5, "The Oculus Quest 2 is incredibly immersive. My favorite VR headset so far.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3765), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3767), 5, 1, "Michael Davis" },
                    { 6, "The Samsung T7 Portable SSD is super fast. Makes transferring files a breeze.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3770), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3772), 6, 1, "Sarah Wilson" },
                    { 7, "The Echo Show 10 is a great smart home hub. The rotating screen is very handy.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3775), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3776), 7, 1, "Chris Martinez" },
                    { 8, "The JBL Flip 5 delivers excellent sound quality, especially for its size.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3867), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3871), 8, 5, "Jessica Taylor" },
                    { 9, "The DJI Mavic Air 2 captures stunning aerial footage. Easy to fly as well.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3876), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3878), 9, 3, "Daniel Anderson" },
                    { 10, "The Nest Learning Thermostat saved me on energy bills. Love the automation features.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3883), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3885), 10, 2, "Sophia Thomas" },
                    { 11, "The Kindle Paperwhite is perfect for reading on the go. The screen is very clear.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3888), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3889), 11, 2, "David Jackson" },
                    { 12, "The Anker Wireless Charging Pad is a convenient way to charge my phone. Works great.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3892), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3893), 12, 4, "Olivia Moore" },
                    { 13, "The Fitbit Charge 5 has helped me stay on top of my fitness goals. Love the new features.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3896), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3898), 13, 4, "Liam Harris" },
                    { 14, "The Arlo Pro 4 Security Camera gives me peace of mind. Easy to set up and use.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3900), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3902), 14, 1, "Ava Martinez" },
                    { 15, "The Bose QuietComfort 45 are the best noise-cancelling headphones I've tried.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3905), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3907), 15, 3, "Noah Robinson" },
                    { 16, "The Philips Hue Smart Bulb adds a lot of ambiance to my room. The color options are great.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3909), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3911), 16, 5, "Isabella Clark" },
                    { 17, "The Anker PowerCore 10000 is a lifesaver on long trips. Charges my devices multiple times.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3914), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3915), 17, 4, "Mason Rodriguez" },
                    { 18, "The iRobot Roomba i7+ keeps my floors clean without any effort. I love the self-emptying feature.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3919), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3920), 18, 3, "Mia Lewis" },
                    { 19, "The Creality Ender 3 V2 is perfect for my 3D printing projects. Easy to assemble and use.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3923), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3925), 19, 3, "Ethan Walker" },
                    { 20, "The Ring Video Doorbell Pro 2 offers clear video and great motion detection. A must-have for home security.", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3927), "", 1, new DateTime(2024, 8, 22, 20, 49, 35, 774, DateTimeKind.Local).AddTicks(3929), 20, 2, "Charlotte Hill" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
