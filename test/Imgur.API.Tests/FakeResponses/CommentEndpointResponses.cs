﻿namespace Imgur.API.Tests.FakeResponses
{
    public class CommentEndpointResponses
    {
        public const string CreateCommentAsync =
            "{\"data\":{\"id\":539710677},\"success\":true,\"status\":200}";

        public const string CreateReplyAsync =
            "{\"data\":{\"id\":539717441},\"success\":true,\"status\":200}";

        public const string DeleteCommentAsync =
            "{\"data\":true,\"success\":true,\"status\":200}";

        public const string GetCommentAsync =
            "{\"data\":{\"id\":539556821,\"image_id\":\"n6gcXdY\",\"comment\":\"It's called smirking. Lots of people do it.\",\"author\":\"WomanWiththeTattooedHands\",\"author_id\":499505,\"on_album\":false,\"album_cover\":null,\"ups\":379,\"downs\":16,\"points\":363,\"datetime\":1450526522,\"parent_id\":0,\"deleted\":false,\"vote\":\"veto\",\"platform\":\"iphone\",\"children\":[]},\"success\":true,\"status\":200}";

        public const string GetCommentReplies =
            "{\"data\":{\"id\":539556821,\"image_id\":\"n6gcXdY\",\"comment\":\"It's called smirking. Lots of people do it.\",\"author\":\"WomanWiththeTattooedHands\",\"author_id\":499505,\"on_album\":false,\"album_cover\":null,\"ups\":411,\"downs\":20,\"points\":391,\"datetime\":1450526522,\"parent_id\":0,\"deleted\":false,\"vote\":null,\"platform\":\"iphone\",\"children\":[{\"id\":539573961,\"image_id\":\"n6gcXdY\",\"comment\":\"http://i.imgur.com/vjweG2l.gifv\",\"author\":\"AkevoTheBard\",\"author_id\":18565620,\"on_album\":false,\"album_cover\":null,\"ups\":137,\"downs\":6,\"points\":131,\"datetime\":1450530307,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"android\",\"children\":[{\"id\":539606005,\"image_id\":\"n6gcXdY\",\"comment\":\"That smirking whore of Highgarden!\",\"author\":\"yumyumbird\",\"author_id\":16198782,\"on_album\":false,\"album_cover\":null,\"ups\":37,\"downs\":0,\"points\":37,\"datetime\":1450536153,\"parent_id\":539573961,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]},{\"id\":539608933,\"image_id\":\"n6gcXdY\",\"comment\":\"http://i.imgur.com/IyZODKt.png\",\"author\":\"Nuuskamuikkunen\",\"author_id\":10586536,\"on_album\":false,\"album_cover\":null,\"ups\":16,\"downs\":0,\"points\":16,\"datetime\":1450536601,\"parent_id\":539573961,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[{\"id\":539653393,\"image_id\":\"n6gcXdY\",\"comment\":\"Cannot unsee\",\"author\":\"alienrobotzombiebear\",\"author_id\":8986131,\"on_album\":false,\"album_cover\":null,\"ups\":3,\"downs\":0,\"points\":3,\"datetime\":1450542750,\"parent_id\":539608933,\"deleted\":false,\"vote\":null,\"platform\":\"android\",\"children\":[{\"id\":539691409,\"image_id\":\"n6gcXdY\",\"comment\":\"Could not unsee even before I saw it\",\"author\":\"TerraDactyl89\",\"author_id\":9915047,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450547404,\"parent_id\":539653393,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]}]}]},{\"id\":539629069,\"image_id\":\"n6gcXdY\",\"comment\":\"I wonder who that dude in the background is angry at.\",\"author\":\"0rpheus\",\"author_id\":24633052,\"on_album\":false,\"album_cover\":null,\"ups\":10,\"downs\":0,\"points\":10,\"datetime\":1450539534,\"parent_id\":539573961,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]},{\"id\":539583181,\"image_id\":\"n6gcXdY\",\"comment\":\"Well that just made me hard\",\"author\":\"imgurwhyudodistome\",\"author_id\":17432886,\"on_album\":false,\"album_cover\":null,\"ups\":20,\"downs\":6,\"points\":14,\"datetime\":1450532214,\"parent_id\":539573961,\"deleted\":false,\"vote\":null,\"platform\":\"android\",\"children\":[{\"id\":539604873,\"image_id\":\"n6gcXdY\",\"comment\":\"I know, Han Solo right?!?!\",\"author\":\"HiTechRedneck\",\"author_id\":19500795,\"on_album\":false,\"album_cover\":null,\"ups\":9,\"downs\":0,\"points\":9,\"datetime\":1450535975,\"parent_id\":539583181,\"deleted\":false,\"vote\":null,\"platform\":\"android\",\"children\":[]}]},{\"id\":539606085,\"image_id\":\"n6gcXdY\",\"comment\":\"And seeing her reminds me of an analogy. It's like spanking - both reward and punishment!\",\"author\":\"notme222\",\"author_id\":8814578,\"on_album\":false,\"album_cover\":null,\"ups\":6,\"downs\":1,\"points\":5,\"datetime\":1450536167,\"parent_id\":539573961,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]},{\"id\":539677953,\"image_id\":\"n6gcXdY\",\"comment\":\"Over capacity :(\",\"author\":\"yusefjalali\",\"author_id\":21978690,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450545790,\"parent_id\":539573961,\"deleted\":false,\"vote\":null,\"platform\":\"iphone\",\"children\":[]}]},{\"id\":539625505,\"image_id\":\"n6gcXdY\",\"comment\":\"Username relevant.\",\"author\":\"ThatQuietlySmirking\",\"author_id\":8028871,\"on_album\":false,\"album_cover\":null,\"ups\":9,\"downs\":1,\"points\":8,\"datetime\":1450539023,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]},{\"id\":539629897,\"image_id\":\"n6gcXdY\",\"comment\":\"As someone who doesnt smile, smirking is the closest I can get to looking normal.\",\"author\":\"ZekeAskirion\",\"author_id\":6024037,\"on_album\":false,\"album_cover\":null,\"ups\":3,\"downs\":0,\"points\":3,\"datetime\":1450539643,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"android\",\"children\":[]},{\"id\":539621865,\"image_id\":\"n6gcXdY\",\"comment\":\"Yeah, but when I smirk the right side of my mouth is the happy side, but right eyebrow is angry. It's a very confusing action for my face.\",\"author\":\"Whatisupwithallthesepeoplewithlongnamesiwillnotconformohwaitno\",\"author_id\":876476,\"on_album\":false,\"album_cover\":null,\"ups\":3,\"downs\":0,\"points\":3,\"datetime\":1450538556,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"iphone\",\"children\":[{\"id\":539622405,\"image_id\":\"n6gcXdY\",\"comment\":\"*my right eyebrow  I'm on mobile and apparently can't edit. The one time I didn't proofread....\",\"author\":\"Whatisupwithallthesepeoplewithlongnamesiwillnotconformohwaitno\",\"author_id\":876476,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450538623,\"parent_id\":539621865,\"deleted\":false,\"vote\":null,\"platform\":\"iphone\",\"children\":[]}]},{\"id\":539697893,\"image_id\":\"n6gcXdY\",\"comment\":\"This is where :p comes in. You know, for internet reference.\",\"author\":\"freedomofnow\",\"author_id\":8056900,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450548215,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]},{\"id\":539684961,\"image_id\":\"n6gcXdY\",\"comment\":\"Like a certain whore from high garden\",\"author\":\"Gearball\",\"author_id\":11992729,\"on_album\":false,\"album_cover\":null,\"ups\":1,\"downs\":0,\"points\":1,\"datetime\":1450546634,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"iphone\",\"children\":[]},{\"id\":539660177,\"image_id\":\"n6gcXdY\",\"comment\":\"Wow. Thanks for ruining the fun madame buzzkill.\",\"author\":\"CJ47\",\"author_id\":1210007,\"on_album\":false,\"album_cover\":null,\"ups\":2,\"downs\":3,\"points\":-1,\"datetime\":1450543584,\"parent_id\":539556821,\"deleted\":false,\"vote\":null,\"platform\":\"desktop\",\"children\":[]}]},\"success\":true,\"status\":200}";

        public const string ReportCommentAsync =
            "{\"data\":null,\"success\":true,\"status\":200}";

        public const string VoteCommentAsync =
            "{\"data\":true,\"success\":true,\"status\":200}";
    }
}