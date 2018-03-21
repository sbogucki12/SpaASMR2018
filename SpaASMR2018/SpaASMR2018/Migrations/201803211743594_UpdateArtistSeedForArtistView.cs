namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateArtistSeedForArtistView : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Artists SET Image = '~/Content/images/GentleWhisperingImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/GentleWhispering', Description = 'Ipsum Lorem' WHERE Id = 4");

            Sql("UPDATE Artists SET Image = '~/Content/images/ASMRGlowImage.JPG', YoutubeUrl = 'https://www.youtube.com/channel/UCFmL725KKPx2URVPvH3Gp8w', Description = 'Ipsum Lorem' WHERE Id = 5");

            Sql("UPDATE Artists SET Image = '~/Content/images/GibiImage.JPG', YoutubeUrl = 'https://www.youtube.com/channel/UCE6acMV3m35znLcf0JGNn7Q', Description = 'Ipsum Lorem' WHERE id = 6");

            Sql("UPDATE Artists SET Image = '~/Content/images/HeatherFeatherImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/HeatherFeatherASMR', Description = 'Ipsum Lorem' WHERE Id = 7");

            Sql("UPDATE Artists SET Image = '~/Content/images/AsmrRequestsImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/ASMRrequests', Description = 'Ipsum Lorem' WHERE id = 8");

            Sql("UPDATE Artists SET Image = '~/Content/images/AsmrDarlingImage.JPG', YoutubeUrl = 'https://www.youtube.com/channel/UCikebqFWoT3QC9axUbXCPYw', Description = 'Ipsum Lorem'WHERE Id = 9");

            Sql("UPDATE Artists SET Image = '~/Content/images/WhispersRedImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/WhispersRedASMR', Description = 'Ipsum Lorem' WHERE Id = 10");

            Sql("UPDATE Artists SET Image = '~/Content/images/MissAsmrImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/videomissasmr', Description = 'Ipsum Lorem' WHERE Id = 11");

            Sql("UPDATE Artists SET Image = '~/Content/images/ArdraImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/ardraneala', Description = 'Ipsum Lorem' WHERE Id = 12");

            Sql("UPDATE Artists SET Image = '~/Content/images/DonnaAsmrImage.JPG', YoutubeUrl = 'https://www.youtube.com/user/DonnaASMR', Description = 'Ipsum Lorem' WHERE Id = 13");
        }
        
        public override void Down()
        {
        }
    }
}
