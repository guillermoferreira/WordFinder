using System;
using System.Collections.Generic;

namespace WordFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> matrixList = new List<string>
            {
                "apple", "banana", "grape", "orange", "mango", "peach", "plum", "cherry", "strawberry", "blueberry",
                "watermelon", "kiwi", "pineapple", "avocado", "tomato", "potato", "carrot", "onion", "garlic", "lettuce",
                "broccoli", "cucumber", "spinach", "zucchini", "asparagus", "celery", "beetroot", "pumpkin", "corn", "peas",
                "bean", "lentil", "chickpea", "walnut", "almond", "cashew", "hazelnut", "pecan", "pistachio", "macadamia",
                "sesame", "flax", "chia", "sunflower", "pumpkinseed", "pine", "coconut", "dates", "fig", "raisin",
                "date", "prune", "apricot", "currant", "elderberry", "goji", "mulberry", "blackberry", "raspberry", "logansberry",
                "gooseberry", "cranberry", "soursop", "passionfruit", "papaya", "dragonfruit", "starfruit", "tamarillo", "longan", "lychee",
                "grapefruit", "persimmon", "jackfruit", "cantaloupe", "nectarine", "bloodorange", "mandarin", "tangerine", "fig", "pluot",
                "kumquat", "satsuma", "pomegranate", "carambola", "durian", "salak", "feijoa", "jambul", "jellybean", "clementine",
                "tomatillo", "radish", "chard", "artichoke", "shallot", "endive", "sweetpotato", "garbanzo", "chard", "rutabaga",
                "fennel", "turnip", "parsnip", "squash", "yam", "celeriac", "tarot", "cabbage", "cauliflower", "cauliflowerrice",
                "broccolini", "bamboo", "collard", "brusselsprouts", "beet", "snowpea", "sugarbeet", "hemp", "asparagus",
                "marrow", "taro", "chives", "mungbean", "coriander", "cilantro", "mint", "oregano", "rosemary", "basil", "thyme",
                "sage", "oregano", "bayleaf", "tarragon", "parsley", "turmeric", "ginger", "paprika", "cumin", "nutmeg", "cardamom",
                "clove", "saffron", "vanilla", "mustard", "sesameoil", "wasabi", "soy", "tamari", "vinegar", "mirin", "rice", "coconutmilk",
                "almondmilk", "cashewmilk", "oatmilk", "soybean", "matcha", "yogurt", "cheese", "cream", "butter", "margarine",
                "lard", "sourcream", "icecream", "gelato", "frozenyogurt", "cheesecake", "pudding", "pie", "brownie", "muffin",
                "cookie", "cupcake", "biscuit", "wafer", "crumble", "flan", "tart", "croissant", "doughnut", "scone", "pancake",
                "waffle", "waffles", "crepe", "pudding", "cupcake", "cinnamonroll", "cake", "layercake", "carrotcake", "chocolatecake",
                "fruitcake", "spicecake", "chiffon", "angelfood", "poundcake", "bundtcake", "redvelvet", "shortcake", "cheesecakes",
                "bakedgood", "bread", "loaf", "bagel", "roll", "croissant", "naan", "pita", "flatbread", "focaccia", "ciabatta",
                "brioche", "ryebread", "multigrain", "sourdough", "wheatbread", "wheatroll", "glutenfree", "lunch", "supper", "dinner",
                "brunch", "picnic", "snack", "meal", "tiffin", "banquet", "buffet", "grill", "barbecue", "hotdog", "hamburger",
                "sandwich", "wrap", "sub", "taco", "burrito", "nachos", "quesadilla", "fajita", "enchilada", "chimichanga", "paella",
                "risotto", "pizza", "pasta", "lasagna", "spaghetti", "macaroni", "ravioli", "gnocchi", "fettuccine", "penne", "fusilli",
                "noodle", "wonton", "dimsum", "dumpling", "sushi", "maki", "sashimi", "tempura", "sake", "teriyaki", "bento",
                "ramen", "udon", "gyoza", "friedrice", "moussaka", "souvlaki", "gyro", "hummus", "tabbouleh", "falafel",
                "lentilsoup", "couscous", "chowder", "bisque", "tortilla", "chili", "stew", "hotpot", "barley", "potpie",
                "vegetable", "chicken", "beef", "lamb", "fish", "pork", "goat", "turkey", "duck", "bacon", "sausage", "ham",
                "venison", "steak", "ribs", "filet", "tenderloin", "cutlet", "meatloaf", "brisket", "jerky", "bangers", "salami",
                "prosciutto", "capicola", "pepperoni", "chorizo", "soppressata", "mortadella", "andouille", "tasso", "hotdog",
                "hamburger", "burger", "meatball", "wiener", "poultry", "gamebird", "quail", "pheasant", "partridge", "turkeybreast",
                "chickensalad", "friedchicken", "chickenwings", "duckbreast", "goose", "roast", "grilled", "baked", "fried", "boiled",
                "poached", "steamed", "smoked", "pickled", "salted", "preserved", "fermented", "sousvide", "canned", "frozen", "marinated",
                "bbq", "roastbeef", "salad", "greens", "vegetarian", "vegan", "plantbased", "meatless", "glutenfree", "dairyfree",
                "sugarfree", "keto", "paleo", "lowcarb", "highprotein", "highfiber", "lowfat", "lowcalorie", "organic", "natural",
                "wholefood", "superfood", "fresh", "local", "sustainable", "nonGMO", "fairtrade", "artisanal", "handcrafted", "smallbatch",
                "craft", "boutique", "homemade", "farmtotable", "slowfood", "seed", "bean", "grain", "nut", "protein", "fiber", "antioxidant",
                "omega3", "vitamin", "mineral", "calcium", "iron", "magnesium", "potassium", "zinc", "iodine", "selenium", "copper",
                "manganese", "phosphorus", "folate", "vitaminA", "vitaminC", "vitaminD", "vitaminE", "vitaminK", "omega6", "omega9",
                "sugars", "glucose", "fructose", "lactose", "sucrose", "glucagon", "insulin", "glycogen", "metabolism", "digestion",
                "carbohydrate", "lipid", "protein", "aminoacid", "enzymes", "hormones", "antibodies", "antimicrobials", "probiotics",
                "prebiotics", "caffeine", "theobromine", "chlorophyll", "flavonoids", "polyphenols", "alkaloids", "carotenoids","apple",
                "banana", "grape", "orange", "mango", "peach", "plum", "cherry", "strawberry", "blueberry",
                "watermelon", "kiwi", "pineapple", "avocado", "tomato", "potato", "carrot", "onion", "garlic", "lettuce",
                "broccoli", "cucumber", "spinach", "zucchini", "asparagus", "celery", "beetroot", "pumpkin", "corn", "peas",
                "bean", "lentil", "chickpea", "walnut", "almond", "cashew", "hazelnut", "pecan", "pistachio", "macadamia",
                "sesame", "flax", "chia", "sunflower", "pumpkinseed", "pine", "coconut", "dates", "fig", "raisin",
                "date", "prune", "apricot", "currant", "elderberry", "goji", "mulberry", "blackberry", "raspberry", "logansberry",
                "gooseberry", "cranberry", "soursop", "passionfruit", "papaya", "dragonfruit", "starfruit", "tamarillo", "longan", "lychee",
                "grapefruit", "persimmon", "jackfruit", "cantaloupe", "nectarine", "bloodorange", "mandarin", "tangerine", "fig", "pluot",
                "kumquat", "satsuma", "pomegranate", "carambola", "durian", "salak", "feijoa", "jambul", "jellybean", "clementine",
                "tomatillo", "radish", "chard", "artichoke", "shallot", "endive", "sweetpotato", "garbanzo", "chard", "rutabaga",
                "fennel", "turnip", "parsnip", "squash", "yam", "celeriac", "tarot", "cabbage", "cauliflower", "cauliflowerrice",
                "brunch", "picnic", "snack", "meal", "tiffin", "banquet", "buffet", "grill", "barbecue", "hotdog", "hamburger",
                "sandwich", "wrap", "sub", "taco", "burrito", "nachos", "quesadilla", "fajita", "enchilada", "chimichanga", "paella",
                "risotto", "pizza", "pasta", "lasagna", "spaghetti", "macaroni", "ravioli", "gnocchi", "fettuccine", "penne", "fusilli",
                "noodle", "wonton", "dimsum", "dumpling", "sushi", "maki", "sashimi", "tempura", "sake", "teriyaki", "bento",
                "ramen", "udon", "gyoza", "friedrice", "moussaka", "souvlaki", "gyro", "hummus", "tabbouleh", "falafel",
                "lentilsoup", "couscous", "chowder", "bisque", "tortilla", "chili", "stew", "hotpot", "barley", "potpie",
                "vegetable", "chicken", "beef", "lamb", "fish", "pork", "goat", "turkey", "duck", "bacon", "sausage", "ham",
                "venison", "steak", "ribs", "filet", "tenderloin", "cutlet", "meatloaf", "brisket", "jerky", "bangers", "salami",
                "prosciutto", "capicola", "pepperoni", "chorizo", "soppressata", "mortadella", "andouille", "tasso", "hotdog",
                "hamburger", "burger", "meatball", "wiener", "poultry", "gamebird", "quail", "pheasant", "partridge", "turkeybreast",
                "chickensalad", "friedchicken", "chickenwings", "duckbreast", "goose", "roast", "grilled", "baked", "fried", "boiled",
                "poached", "steamed", "smoked", "pickled", "salted", "preserved", "fermented", "sousvide", "canned", "frozen", "marinated",
                "bbq", "roastbeef", "salad", "greens", "vegetarian", "vegan", "plantbased", "meatless", "glutenfree", "dairyfree",
                "sugarfree", "keto", "paleo", "lowcarb", "highprotein", "highfiber", "lowfat", "lowcalorie", "organic", "natural",
                "wholefood", "superfood", "fresh", "local", "sustainable", "nonGMO", "fairtrade", "artisanal", "handcrafted", "smallbatch",
                "craft", "boutique", "homemade", "farmtotable", "slowfood", "seed", "bean", "grain", "nut", "protein", "fiber", "antioxidant"
            };

            // Create the 64x64 matrix based on a list of words to test the app
            var matrix = new List<string>();
            var rowstring = string.Empty;

            foreach (string s in matrixList)
            {
                rowstring += rowstring.Length + s.Length <= 64 ? s : s.Substring(0, 64 - rowstring.Length);

                if (rowstring.Length == 64)
                {
                    matrix.Add(rowstring);
                    rowstring = string.Empty;

                    if (matrix.Count == 64) break;
                }
            }

            List<string> wordstream = new List<string>
            {
                "apple", "banana", "grape", "orange", "mango", "peach", "plum", "cherry", "strawberry", "blueberry",
                "watermelon", "kiwi", "pineapple", "avocado", "tomato", "potato", "carrot", "onion", "garlic", "lettuce",
                "broccoli", "cucumber", "spinach", "zucchini", "asparagus", "celery", "beetroot", "pumpkin", "corn", "peas",
                "bean", "lentil", "chickpea", "walnut", "almond", "cashew", "hazelnut", "pecan", "pistachio", "macadamia",
                "sesame", "flax", "chia", "sunflower", "pumpkinseed", "pine", "coconut", "dates", "fig", "raisin",
                "date", "prune", "apricot", "currant", "elderberry", "goji", "mulberry", "blackberry", "raspberry", "logansberry",
                "gooseberry", "cranberry", "soursop", "passionfruit", "papaya", "dragonfruit", "starfruit", "tamarillo", "longan", "lychee",
                "grapefruit", "persimmon", "jackfruit", "cantaloupe", "nectarine", "bloodorange", "mandarin", "tangerine", "fig", "pluot",
                "kumquat", "satsuma", "pomegranate", "carambola", "durian", "salak", "feijoa", "jambul", "jellybean", "clementine",
                "tomatillo", "radish", "chard", "artichoke", "shallot", "endive", "sweetpotato", "garbanzo", "chard", "rutabaga",
                "fennel", "turnip", "parsnip", "squash", "yam", "celeriac", "tarot", "cabbage", "cauliflower", "cauliflowerrice",
                "broccolini", "bamboo", "collard", "brusselsprouts", "beet", "snowpea", "sugarbeet", "hemp", "asparagus",
                "marrow", "taro", "chives", "mungbean", "coriander", "cilantro", "mint", "oregano", "rosemary", "basil", "thyme",
                "sage", "oregano", "bayleaf", "tarragon", "parsley", "turmeric", "ginger", "paprika", "cumin", "nutmeg", "cardamom",
                "clove", "saffron", "vanilla", "mustard", "sesameoil", "wasabi", "soy", "tamari", "vinegar", "mirin", "rice", "coconutmilk",
                "almondmilk", "cashewmilk", "oatmilk", "soybean", "matcha", "yogurt", "cheese", "cream", "butter", "margarine",
                "lard", "sourcream", "icecream", "gelato", "frozenyogurt", "cheesecake", "pudding", "pie", "brownie", "muffin",
                "cookie", "cupcake", "biscuit", "wafer", "crumble", "flan", "tart", "croissant", "doughnut", "scone", "pancake",
                "waffle", "waffles", "crepe", "pudding", "cupcake", "cinnamonroll", "cake", "layercake", "carrotcake", "chocolatecake",
                "fruitcake", "spicecake", "chiffon", "angelfood", "poundcake", "bundtcake", "redvelvet", "shortcake", "cheesecakes",
                "bakedgood", "bread", "loaf", "bagel", "roll", "croissant", "naan", "pita", "flatbread", "focaccia", "ciabatta",
                "brioche", "ryebread", "multigrain", "sourdough", "wheatbread", "wheatroll", "glutenfree", "lunch", "supper", "dinner",
                "brunch", "picnic", "snack", "meal", "tiffin", "banquet", "buffet", "grill", "barbecue", "hotdog", "hamburger",
                "sandwich", "wrap", "sub", "taco", "burrito", "nachos", "quesadilla", "fajita", "enchilada", "chimichanga", "paella",
                "risotto", "pizza", "pasta", "lasagna", "spaghetti", "macaroni", "ravioli", "gnocchi", "fettuccine", "penne", "fusilli",
                "noodle", "wonton", "dimsum", "dumpling", "sushi", "maki", "sashimi", "tempura", "sake", "teriyaki", "bento",
                "ramen", "udon", "gyoza", "friedrice", "moussaka", "souvlaki", "gyro", "hummus", "tabbouleh", "falafel",
                "lentilsoup", "couscous", "chowder", "bisque", "tortilla", "chili", "stew", "hotpot", "barley", "potpie",
                "vegetable", "chicken", "beef", "lamb", "fish", "pork", "goat", "turkey", "duck", "bacon", "sausage", "ham",
                "venison", "steak", "ribs", "filet", "tenderloin", "cutlet", "meatloaf", "brisket", "jerky", "bangers", "salami",
                "prosciutto", "capicola", "pepperoni", "chorizo", "soppressata", "mortadella", "andouille", "tasso", "hotdog",
                "hamburger", "burger", "meatball", "wiener", "poultry", "gamebird", "quail", "pheasant", "partridge", "turkeybreast",
                "chickensalad", "friedchicken", "chickenwings", "duckbreast", "goose", "roast", "grilled", "baked", "fried", "boiled",
                "poached", "steamed", "smoked", "pickled", "salted", "preserved", "fermented", "sousvide", "canned", "frozen", "marinated",
                "bbq", "roastbeef", "salad", "greens", "vegetarian", "vegan", "plantbased", "meatless", "glutenfree", "dairyfree",
                "sugarfree", "keto", "paleo", "lowcarb", "highprotein", "highfiber", "lowfat", "lowcalorie", "organic", "natural",
                "wholefood", "superfood", "fresh", "local", "sustainable", "nonGMO", "fairtrade", "artisanal", "handcrafted", "smallbatch",
                "craft", "boutique", "homemade", "farmtotable", "slowfood", "seed", "bean", "grain", "nut", "protein", "fiber", "antioxidant",
                "omega3", "vitamin", "mineral", "calcium", "iron", "magnesium", "potassium", "zinc", "iodine", "selenium", "copper",
                "manganese", "phosphorus", "folate", "vitaminA", "vitaminC", "vitaminD", "vitaminE", "vitaminK", "omega6", "omega9",
                "sugars", "glucose", "fructose", "lactose", "sucrose", "glucagon", "insulin", "glycogen", "metabolism", "digestion",
                "carbohydrate", "lipid", "protein", "aminoacid", "enzymes", "hormones", "antibodies", "antimicrobials", "probiotics",
                "prebiotics", "caffeine", "theobromine", "chlorophyll", "fiber", "digestive", "nutrient", "micronutrient", "macronutrient",
                "antioxidant", "phytonutrient", "diet", "hydration", "detox", "cleanse", "detoxification", "balance", "wellness", "health",
                "exercise", "workout", "cardio", "strength", "aerobics", "yoga", "pilates", "stretch", "recovery", "sports", "active",
                "movement", "flexibility", "endurance", "strengthtraining", "crossfit", "gym", "fitness", "run", "cycling", "swim",
                "hiking", "climbing", "skiing", "snowboarding", "surfing", "paddleboarding", "rockclimbing", "boxing", "martialarts",
                "kickboxing", "rowing", "rowingmachine", "spinning", "aquaexercise", "swimmingpool", "play", "game", "leisure", "fun",
                "hobby", "vacation", "holiday", "travel", "tourism", "adventure", "explore", "destination", "journey", "trip", "flight",
                "hotel", "resort", "tour", "excursion", "trek", "adventure", "sightseeing", "cruise", "beach", "mountain", "ocean",
                "lake", "river", "forest", "desert", "city", "country", "culture", "history", "museum", "monument", "landmark",
                "architecture", "scenery", "view", "landscape", "nature", "wilderness", "park", "reserve", "safari", "nationalpark",
                "wildlife", "zoo", "aquarium", "planetarium", "botanicalgarden", "wildlifepark", "ecotourism", "sustainabletourism",
                "responsibletourism", "globetrotter", "nomad", "traveller", "explorer", "backpacker", "vacationer", "tourist", "visitor",
                "holidaymaker", "staycation", "tripadvisor", "tourismguide", "travelblog", "wanderlust", "journeyer", "adventurer"
            };

            var wordFinder = new WordFinder(matrix);
            var results = wordFinder.Find(wordstream);

            Console.WriteLine("Top 10 list");
            foreach (var result in results) 
            { 
                Console.WriteLine(result);
            }                
        }
    }        
}
