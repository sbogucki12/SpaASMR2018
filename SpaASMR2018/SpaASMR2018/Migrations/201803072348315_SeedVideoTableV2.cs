namespace SpaASMR2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVideoTableV2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Personal Attention: Face Touching with Gloves + Tweezers', 'https://www.youtube.com/watch?v=5TIEzpYTHbU', 2, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Haircut Role Play', 'https://www.youtube.com/watch?v=05CX4gblHaE', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR 3DIO TEST (Ear brushing, Ear tapping, Finger Flutter, Ear cupping, Ear touching..)', 'https://www.youtube.com/watch?v=Z6R9gQogAJ4', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR 10 Personal Attention Triggers', 'https://www.youtube.com/watch?v=GRYHQHMFgp8&t=762s', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Spa (Scalp Massage, Face Massage, Personal Attention, Lotion, Gloves, Cottons, Tapping..)', 'https://www.youtube.com/watch?v=OOkiD7noeV8', 4, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Personal Attention Roleplay: Face Massage, Cream Sounds, Tweezing, Cottons', 'https://www.youtube.com/watch?v=7xELudftMlw&t=15s', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR 21 Personal Attention Triggers (Scalp massage, Haircut, Wet sounds, Face brushing, kisses..)', 'https://www.youtube.com/watch?v=500qh8-szm4&t=1302s', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Cranial Nerve Exam', 'https://www.youtube.com/watch?v=9YfpnGFBA7M', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Fixing You Part 2 Whispered Roleplay (Gloves sounds, Face Brushing, Scratching sounds and +)', 'https://www.youtube.com/watch?v=wtSYFiAP3FE', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Scalp Massage', 'https://www.youtube.com/watch?v=oUwP4Ft-EQk&t=381s', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Whispered Positive Affirmations', 'https://www.youtube.com/watch?v=RYTAfxpJTV0', 1, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Haircut Role Play (Scalp Massage, Shaving, Hair Brushing, Hair Inspection, Shampoo...)', 'https://www.youtube.com/watch?v=nJcFALXvLf0', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Face Brushing + Face Touching', 'https://www.youtube.com/watch?v=tbMgFb-MOqw', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Fixing You Whispered Roleplay (Gloves sounds, Face Brushing, Scratching sounds and +)', 'https://www.youtube.com/watch?v=mm6-oVEsvi4', 3, 5)");
            Sql("INSERT INTO Videos (Name, Url, VideoGenreId, ArtistId) VALUES ('ASMR Fixing You Whispered Roleplay (Gloves sounds, Face Brushing, Scratching sounds and +)', 'https://www.youtube.com/watch?v=mm6-oVEsvi4', 3, 5)");
        }


        public override void Down()
        {
        }
    }
}
