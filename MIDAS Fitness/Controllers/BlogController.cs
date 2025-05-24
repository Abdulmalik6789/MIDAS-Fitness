using Microsoft.AspNetCore.Mvc;
using MIDAS_Fitness.Models;

namespace MIDAS_Fitness.Controllers
{
    public class BlogController : Controller
    {
        // Sample blog data (in a real application, this would come from a database)
        private static List<BlogPost> _blogPosts = new List<BlogPost>
        {
            new BlogPost
            {
                Id = 1,
                Title = "10 Effective Workout Routines for Beginners",
                Excerpt = "Starting your fitness journey can be overwhelming. Here are 10 effective workout routines perfect for beginners.",
                Content = "Starting your fitness journey can be overwhelming. With so many workout options available, it's hard to know where to begin. This blog post outlines 10 effective workout routines that are perfect for beginners. These routines focus on building foundational strength, improving flexibility, and increasing endurance without overwhelming newcomers to fitness.\n\nEach routine includes a warm-up, main exercise components, and a cool-down period. We've also included modifications for different fitness levels and any physical limitations. Remember, consistency is key when starting a new fitness regimen. Start with 2-3 workouts per week and gradually increase as your body adapts.\n\nRoutine 1: Full Body Basics\n- 5-minute cardio warm-up (brisk walking or light jogging)\n- 10 bodyweight squats\n- 10 modified push-ups\n- 30-second plank\n- 10 walking lunges (each leg)\n- 10 dumbbell rows (each arm) with light weight\n- 5-minute stretching cool-down\n\nRepeat the circuit 2-3 times with 60-second rest between circuits.",
                Author = "Sarah Johnson",
                PublishedDate = DateTime.Now.AddDays(-30),
                ImageUrl = "/images/beginner-workout.jpg",
                Category = "Workouts",
                Tags = new List<string> { "Beginners", "Workout Routines", "Fitness Tips" },
                ViewCount = 1250
            },
            new BlogPost
            {
                Id = 2,
                Title = "Nutrition Fundamentals: Fueling Your Fitness Journey",
                Excerpt = "Learn the basics of nutrition to complement your workout routine and maximize your fitness results.",
                Content = "Proper nutrition is the foundation of any successful fitness journey. No matter how hard you train, you won't see optimal results without fueling your body correctly. This comprehensive guide covers the nutrition fundamentals you need to know to support your fitness goals.\n\nWe'll explore macronutrients (proteins, carbohydrates, and fats) and their roles in your body, optimal meal timing around workouts, hydration strategies, and how to adjust your nutrition based on your specific fitness goals.\n\nProtein: The Building Block\nProtein is essential for muscle repair and growth. Aim for 1.6-2.2g of protein per kg of bodyweight daily if you're actively training. Good sources include:\n- Lean meats (chicken, turkey, lean beef)\n- Fish and seafood\n- Eggs\n- Dairy products (Greek yogurt, cottage cheese)\n- Plant-based options (tofu, tempeh, legumes)\n\nCarbohydrates: Your Energy Source\nCarbs provide the energy needed for high-intensity workouts. Focus on complex carbohydrates such as:\n- Whole grains (brown rice, quinoa, oats)\n- Starchy vegetables (sweet potatoes, squash)\n- Fruits\n- Legumes\n\nHealthy Fats: Essential for Hormones\nDon't fear fats – they're crucial for hormone production and vitamin absorption. Include sources like:\n- Avocados\n- Nuts and seeds\n- Olive oil\n- Fatty fish (salmon, mackerel)\n\nRemember, nutrition should be personalized to your specific needs, goals, and preferences. There's no one-size-fits-all approach to nutrition.",
                Author = "Michael Chen, RD",
                PublishedDate = DateTime.Now.AddDays(-15),
                ImageUrl = "/images/nutrition-basics.jpg",
                Category = "Nutrition",
                Tags = new List<string> { "Nutrition", "Meal Planning", "Macronutrients" },
                ViewCount = 980
            },
            new BlogPost
            {
                Id = 3,
                Title = "The Science of Recovery: Why Rest Days Matter",
                Excerpt = "Discover why recovery is just as important as your workouts and how to optimize your rest days.",
                Content = "In the fitness world, there's often an emphasis on pushing harder, training more frequently, and constantly challenging yourself. While dedication and consistency are important, many people overlook a crucial component of any successful fitness regimen: recovery.\n\nThis article explores the science behind recovery and why rest days are not just beneficial but essential for your progress. We'll cover the physiological processes that occur during recovery, signs of overtraining, and strategies to optimize your rest days.\n\nWhat Happens During Recovery?\nContrary to popular belief, your muscles don't grow during your workout – they grow during recovery. When you exercise, you create microscopic tears in your muscle fibers. During rest periods, your body repairs these tears, building the muscle back stronger than before. This process, called muscle protein synthesis, requires adequate rest, nutrition, and sleep.\n\nSigns You Need More Recovery:\n- Persistent soreness that doesn't improve\n- Decreased performance\n- Chronic fatigue\n- Mood changes or irritability\n- Trouble sleeping\n- Elevated resting heart rate\n- Frequent illnesses or infections\n\nOptimizing Your Rest Days:\n1. Active Recovery: Light activities like walking, swimming, or yoga can increase blood flow without taxing your system.\n2. Proper Nutrition: Focus on protein for repair and carbohydrates to replenish glycogen stores.\n3. Hydration: Water is essential for all recovery processes.\n4. Sleep: Aim for 7-9 hours of quality sleep.\n5. Stress Management: Practices like meditation can help lower cortisol levels.\n6. Mobility Work: Foam rolling and stretching can alleviate tightness.\n\nRemember, recovery isn't just physical – it's mental too. Taking time away from intense training can prevent burnout and keep you motivated long-term.",
                Author = "Dr. James Wilson",
                PublishedDate = DateTime.Now.AddDays(-7),
                ImageUrl = "/images/recovery-science.jpg",
                Category = "Recovery",
                Tags = new List<string> { "Recovery", "Rest Days", "Sleep", "Overtraining" },
                ViewCount = 1450
            },
            new BlogPost
            {
                Id = 4,
                Title = "Finding Your 'Why': The Key to Fitness Motivation",
                Excerpt = "Learn how to discover and connect with your deeper motivation to stay consistent with your fitness goals.",
                Content = "When it comes to fitness, motivation is often the missing piece of the puzzle. Many people start their fitness journey with enthusiasm but struggle to maintain consistency over time. The secret to long-term adherence isn't willpower or discipline alone – it's connecting with your deeper 'why.'\n\nIn this article, we explore how to discover your core motivation for fitness and how to use it as fuel when challenges arise. We'll also share strategies for reconnecting with your 'why' during inevitable motivation slumps.\n\nDiscovering Your Fitness 'Why'\nYour 'why' is the underlying reason you want to improve your fitness. It's deeply personal and goes beyond surface-level goals like 'looking good.' To find your true motivation:\n\n1. Ask yourself 'why' five times: Start with your initial goal (e.g., 'I want to lose weight') and keep asking 'why?' until you reach the core reason.\n2. Visualize your future self: Imagine yourself one year from now having achieved your fitness goals. How does it feel? What's different about your life?\n3. Reflect on past attempts: What derailed your previous fitness efforts? Understanding these patterns can reveal what truly matters to you.\n\nCommon Deeper Motivations:\n- Being able to play actively with your children or grandchildren\n- Regaining independence after injury or illness\n- Managing a health condition without medication\n- Improving mental health and reducing anxiety\n- Setting an example for loved ones\n- Challenging yourself and proving your capabilities\n\nKeeping Your 'Why' Visible\nOnce you've identified your core motivation, make it impossible to ignore:\n- Write it down and place it where you'll see it daily\n- Create a vision board with images representing your 'why'\n- Set it as your phone wallpaper\n- Share it with an accountability partner\n\nRemember, motivation naturally fluctuates. When it's low, having a meaningful 'why' can be the difference between giving up and pushing through.",
                Author = "Lisa Thompson",
                PublishedDate = DateTime.Now.AddDays(-10),
                ImageUrl = "/images/fitness-motivation.jpg",
                Category = "Motivation",
                Tags = new List<string> { "Motivation", "Goals", "Mindset", "Consistency" },
                ViewCount = 2100
            },
            new BlogPost
            {
                Id = 5,
                Title = "From Couch to Marathon: Maria's Transformation Story",
                Excerpt = "How Maria went from sedentary office worker to marathon finisher in just 18 months.",
                Content = "Two years ago, Maria Rodriguez couldn't run for more than 60 seconds without stopping. Today, she's completed three marathons and is training for her first ultramarathon. This is her remarkable journey from couch to finish line.\n\nThe Breaking Point\nMaria's story begins like many others – with a wake-up call. 'I was 36, working 60+ hours a week at my desk job, and completely sedentary,' she recalls. 'One day, I couldn't keep up with my 5-year-old nephew at the park. I was winded after just a few minutes of play, and it hit me hard: if I couldn't keep up with him now, what would happen as he got older?'\n\nThat moment of clarity led Maria to make a commitment to change. But rather than diving into an extreme program, she started small.\n\nThe First Steps\nMaria began with a simple couch-to-5K program, which involved alternating between walking and jogging. 'The first day, I could only jog for 60 seconds at a time, and even that was a struggle,' she says. 'But I kept showing up, three times a week, rain or shine.'\n\nAfter 8 weeks, Maria completed her first 5K race. 'I was near the back of the pack, but crossing that finish line felt like winning an Olympic gold medal.'\n\nBuilding Momentum\nRather than stopping at 5K, Maria set her sights on a 10K, then a half marathon. 'Each new distance seemed impossible at first, but I'd learned to trust the process of gradual progression.'\n\nAlong the way, Maria made other changes. She improved her nutrition, prioritized sleep, and found a community of supportive runners. 'The lifestyle changes happened naturally as I fell in love with how running made me feel.'\n\nThe Marathon Journey\nEighteen months after her first 60-second jog, Maria lined up at the start of her first marathon. 'I was terrified, questioning if I belonged there among 'real' runners. But then I remembered how far I'd come and knew I'd earned my place.'\n\nMaria finished in 4:45:23 – far from a course record, but a personal triumph. 'Crossing that finish line changed how I see myself. If I could do this – something that once seemed utterly impossible – what else might I be capable of?'\n\nLessons Learned\nMaria's journey taught her valuable lessons that apply beyond running:\n\n1. Consistency trumps intensity: 'Showing up regularly for moderate workouts accomplished more than occasional all-out efforts.'\n2. Progress isn't linear: 'Some weeks I improved; others I seemed to go backward. The overall trend is what matters.'\n3. Community is crucial: 'Finding people who believed in me when I didn't believe in myself made all the difference.'\n4. Identity drives behavior: 'Once I began to see myself as an athlete, making healthy choices became easier.'\n\nWhat's Next\nNow 38, Maria is training for her first 50K ultramarathon while mentoring new runners. 'The greatest reward is helping someone else discover what they're capable of,' she says. 'We all have untapped potential just waiting to be realized.'",
                Author = "Carlos Mendez",
                PublishedDate = DateTime.Now.AddDays(-5),
                ImageUrl = "/images/success-story-maria.jpg",
                Category = "Success Stories",
                Tags = new List<string> { "Success Story", "Running", "Transformation", "Marathon" },
                ViewCount = 1850
            },
            new BlogPost
            {
                Id = 6,
                Title = "5 Common Weightlifting Mistakes and How to Fix Them",
                Excerpt = "Avoid these frequent errors to maximize your results and prevent injuries in your strength training routine.",
                Content = "Weightlifting is one of the most effective ways to build strength, increase metabolism, and improve overall health. However, many people unknowingly make mistakes that limit their progress and increase injury risk. In this article, we'll cover five common weightlifting errors and provide practical solutions to fix them.\n\nMistake #1: Prioritizing Weight Over Form\nMany lifters focus too much on the number on the barbell and not enough on how they're moving. This is perhaps the most common and dangerous mistake in the gym.\n\nThe Fix: Drop your ego along with the weight. Start with a load that allows you to perform the exercise with perfect form for all prescribed repetitions. Record yourself from different angles to assess your technique, or work with a qualified coach for feedback. Remember, proper form activates the target muscles more effectively and keeps you safe.\n\nMistake #2: Neglecting Progressive Overload\nOn the flip side, some lifters use the same weights for months or years without challenging themselves to improve.\n\nThe Fix: Track your workouts and aim to progressively increase either the weight, repetitions, sets, or decrease rest periods over time. Even small improvements add up – adding just 2.5 pounds to your lifts each week would result in 130 pounds of progress in a year!\n\nMistake #3: Inconsistent Tempo\nRushing through repetitions, especially on the lowering (eccentric) phase, reduces effectiveness and increases injury risk.\n\nThe Fix: Control the weight throughout the entire range of motion. A good starting point for many exercises is 2 seconds on the way down, a brief pause, then 1-2 seconds on the way up. This increases time under tension and improves muscle development.\n\nMistake #4: Improper Breathing\nHolding your breath randomly or breathing at the wrong time during lifts reduces stability and power.\n\nThe Fix: For most exercises, inhale during the easier phase (usually the lowering portion) and exhale during the challenging phase (usually the lifting portion). For heavy compound movements like squats and deadlifts, learn proper bracing by taking a deep breath into your belly before beginning the rep, holding it to create intra-abdominal pressure during the most challenging part, then exhaling at the end.\n\nMistake #5: Unbalanced Programming\nMany lifters focus too much on certain movements or body parts (often chest and arms) while neglecting others (like legs and back).\n\nThe Fix: Follow a well-designed program that includes a balance of pushing, pulling, squatting, hinging, and core exercises. Ensure you're training all major movement patterns and muscle groups with appropriate volume. Consider working with a qualified coach to develop a balanced program suited to your goals.\n\nImplementing these fixes won't just improve your results – it will also extend your lifting career by reducing injury risk. Remember that weightlifting is a skill that improves with practice and attention to detail.",
                Author = "Marcus Johnson",
                PublishedDate = DateTime.Now.AddDays(-12),
                ImageUrl = "/images/weightlifting-mistakes.jpg",
                Category = "Workouts",
                Tags = new List<string> { "Weightlifting", "Form", "Technique", "Strength Training" },
                ViewCount = 1320
            },
            new BlogPost
            {
                Id = 7,
                Title = "The Ultimate Guide to Post-Workout Nutrition",
                Excerpt = "Learn what and when to eat after exercise to maximize recovery, muscle growth, and performance.",
                Content = "What you eat after your workout can be just as important as the workout itself. Proper post-workout nutrition accelerates recovery, replenishes energy stores, and provides the building blocks for muscle repair and growth. This comprehensive guide will help you optimize your post-workout nutrition strategy.\n\nThe Anabolic Window: Myth vs. Reality\nFor years, fitness enthusiasts believed in a narrow 'anabolic window' – typically 30-60 minutes after training – during which you had to consume nutrients or miss out on gains. Current research presents a more nuanced view.\n\nThe Truth: While immediate post-workout nutrition can be beneficial, the anabolic window is wider than previously thought. If you've eaten a meal 2-3 hours before training, the urgency to refuel immediately is reduced. However, if you train fasted or it's been several hours since your last meal, prioritizing post-workout nutrition becomes more important.\n\nWhat to Eat After a Workout\n\nProtein: The Repair Nutrient\nProtein provides the amino acids necessary for muscle repair and growth. Aim for 20-40g of high-quality protein after training, depending on your body size and workout intensity.\n\nGood sources include:\n- Whey protein (fastest absorbing)\n- Chicken or turkey breast\n- Fish\n- Greek yogurt\n- Eggs\n- Plant-based options like tofu or a combination of rice and peas\n\nCarbohydrates: The Recovery Accelerator\nCarbohydrates replenish muscle glycogen (stored energy) and enhance protein uptake by triggering insulin release. The amount you need depends on your workout type:\n\n- For strength training: 0.5-0.7g per kg of bodyweight\n- For endurance training: 1.0-1.2g per kg of bodyweight\n\nGood sources include:\n- White rice (digests easily)\n- Potatoes\n- Fruits (especially bananas)\n- Oats\n- Whole grain bread\n\nFats: Supportive but Secondary\nWhile healthy fats are important for overall health, they slow digestion and aren't the primary focus of post-workout nutrition. A small amount is fine, but consider saving most of your fat intake for other meals.\n\nHydration: The Overlooked Element\nRehydration is crucial after sweating during exercise. Aim to drink 16-24 oz of fluid for every pound lost during exercise. Adding electrolytes can enhance rehydration, especially after intense or long workouts in hot conditions.\n\nPractical Post-Workout Meal Ideas\n\n1. Quick Options (within 30 minutes):\n   - Protein shake with banana\n   - Greek yogurt with berries and honey\n   - Chocolate milk (provides protein, carbs, and fluid)\n\n2. Complete Meals (within 2 hours):\n   - Chicken breast with rice and vegetables\n   - Salmon with sweet potato and salad\n   - Omelette with toast and fruit\n   - Tofu stir-fry with rice\n\nSpecial Considerations\n\nTraining for Fat Loss: Even when in a caloric deficit, post-workout nutrition remains important. Focus on protein while moderating carbohydrates based on your overall diet plan.\n\nMultiple Training Sessions: If you train more than once per day, prioritizing immediate refueling becomes more critical for performance in the second session.\n\nEvening Workouts: If you train late, a combination of protein and carbohydrates can still support recovery without disrupting sleep.\n\nRemember that post-workout nutrition should be part of a well-designed overall nutrition strategy. The best approach is one you can maintain consistently that fits your schedule, preferences, and goals.",
                Author = "Dr. Alicia Rodriguez",
                PublishedDate = DateTime.Now.AddDays(-8),
                ImageUrl = "/images/post-workout-nutrition.jpg",
                Category = "Nutrition",
                Tags = new List<string> { "Nutrition", "Recovery", "Protein", "Post-Workout" },
                ViewCount = 1680
            },
            new BlogPost
            {
                Id = 8,
                Title = "Mobility vs. Flexibility: Understanding the Difference",
                Excerpt = "Learn the crucial distinctions between mobility and flexibility, and why both matter for your fitness and daily life.",
                Content = "The terms 'mobility' and 'flexibility' are often used interchangeably in fitness discussions, but they represent distinct physical qualities that affect your performance and health in different ways. Understanding the difference can help you address specific limitations and create a more effective training program.\n\nDefining the Terms\n\nFlexibility: The ability of a muscle to lengthen passively through a range of motion. Flexibility is about how far a muscle can stretch when external forces (like gravity or another person) are applied.\n\nMobility: The ability to move a joint through its complete range of motion with control. Mobility requires not just muscle flexibility, but also strength, coordination, and proper joint function.\n\nA Simple Analogy\nThink of flexibility as how far a rubber band can stretch when pulled. Mobility, on the other hand, is like being able to stretch that rubber band and then use it functionally – with control and purpose.\n\nWhy the Distinction Matters\nMany people focus exclusively on stretching to improve their movement capabilities, but this addresses only one piece of the puzzle. You might be able to achieve certain positions passively (flexibility) but lack the strength and control to use those ranges actively (mobility).\n\nFor example, a person might be able to touch their toes when bending forward relaxed (good hamstring flexibility) but struggle to maintain proper form in a deadlift (poor hip mobility).\n\nAssessing Your Needs\n\nSigns of Limited Flexibility:\n- Feeling a strong stretch sensation that limits movement\n- Being able to reach positions with assistance but not independently\n- Muscle tightness that feels like tension rather than weakness\n\nSigns of Limited Mobility:\n- Difficulty controlling movements at end ranges\n- Compensating with other body parts to achieve positions\n- Feeling 'stuck' or 'blocked' rather than stretched\n- Pain or discomfort in joints during movement\n\nImproving Flexibility\nFlexibility responds well to various stretching techniques:\n\n1. Static Stretching: Holding a stretch position for 30-60 seconds\n2. PNF (Proprioceptive Neuromuscular Facilitation): Contract-relax techniques that involve alternating contraction and stretching\n3. Passive Stretching: Having a partner or prop help you achieve deeper stretches\n\nImproving Mobility\nMobility work requires a more comprehensive approach:\n\n1. Joint Articulation: Moving joints through full ranges of motion with control\n2. Active Stretching: Actively holding end ranges without external assistance\n3. Loaded Mobility: Using light resistance through full ranges of motion\n4. Movement Pattern Training: Practicing functional movements with proper form\n5. Myofascial Release: Using foam rollers or massage tools to address tissue restrictions\n\nPractical Applications\n\nFor Athletes:\nSport-specific mobility is crucial for performance and injury prevention. Identify the key movements in your sport and ensure you have both the flexibility and active control needed for those patterns.\n\nFor General Fitness:\nFocus on mobility for movements used in daily life and your exercise program. Prioritize hip, shoulder, ankle, and thoracic spine mobility, as these areas commonly limit performance.\n\nFor Injury Rehabilitation:\nWork with a physical therapist to address both passive flexibility and active mobility. Regaining range of motion is only beneficial if you can control and use it functionally.\n\nBalanced Approach\nThe ideal training program includes elements that address both flexibility and mobility. Static stretching has its place, but should be complemented with active mobility work for optimal results.\n\nRemember that improving either quality takes time and consistency. Focus on quality of movement rather than achieving extreme ranges, and always respect pain signals from your body.",
                Author = "Tyler Washington, DPT",
                PublishedDate = DateTime.Now.AddDays(-18),
                ImageUrl = "/images/mobility-flexibility.jpg",
                Category = "Recovery",
                Tags = new List<string> { "Mobility", "Flexibility", "Stretching", "Movement" },
                ViewCount = 890
            },
            new BlogPost
            {
                Id = 9,
                Title = "How John Transformed His Health After a Diabetes Diagnosis",
                Excerpt = "At 45, John received a Type 2 diabetes diagnosis that became his wake-up call to transform his health through fitness and nutrition.",
                Content = "Five years ago, John Miller sat in his doctor's office receiving news that would change his life: at 45 years old, he had developed Type 2 diabetes. With a fasting blood glucose of 268 mg/dL and an A1C of 9.2%, his doctor presented two options: start medication immediately or make dramatic lifestyle changes. John chose the latter, embarking on a journey that would transform not just his health metrics but his entire life.\n\n\"That diagnosis was terrifying, but also clarifying,\" John recalls. \"Suddenly, all the excuses I'd made for years about being too busy to exercise or too stressed to eat well seemed hollow when faced with the reality of a chronic disease.\"\n\nThe First Steps\nJohn didn't overhaul his life overnight. Instead, he started with two manageable changes: walking 30 minutes daily and eliminating sugary beverages. \"I replaced my daily soda habit with water and started walking around my neighborhood after dinner. Those two changes alone made a difference within weeks.\"\n\nAs these small habits became routine, John gradually added more changes. He found a nutritionist who specialized in diabetes management and developed an eating plan that focused on blood sugar control while remaining sustainable.\n\n\"The key was finding an approach I could maintain long-term,\" John explains. \"Previous diets had always failed because they were too restrictive. This time, I focused on balanced meals with protein, healthy fats, and complex carbohydrates.\"\n\nDiscovering Strength Training\nThree months into his journey, John's walking routine no longer felt challenging. On his nutritionist's recommendation, he hired a personal trainer for two sessions to learn basic strength training exercises.\n\n\"I was intimidated at first,\" John admits. \"At 267 pounds with no athletic background, I felt out of place in the gym. But my trainer helped me develop a simple routine I could do three times a week.\"\n\nStrength training became a cornerstone of John's fitness regimen. Not only did it help him build muscle and increase his metabolism, but it also improved his insulin sensitivity – a crucial factor in managing diabetes.\n\nMeasurable Progress\nSix months after his diagnosis, John returned to his doctor for follow-up testing. His fasting glucose had dropped to 142 mg/dL and his A1C to 7.1% – still above normal range but significantly improved. He had also lost 34 pounds.\n\n\"Seeing those numbers improve was incredibly motivating,\" John says. \"For the first time, I realized I had real control over my health outcomes.\"\n\nBy the one-year mark, John's metrics had improved even further: fasting glucose of 118 mg/dL, A1C of 6.2%, and a total weight loss of 62 pounds. His doctor reduced his diabetes classification to \"prediabetic\" and noted that if he maintained his lifestyle changes, he might eventually achieve normal blood sugar levels without medication.\n\nBeyond the Numbers\nWhile the health metrics were important, John found that the benefits of his lifestyle changes extended far beyond laboratory values.\n\n\"I sleep better. My energy has skyrocketed. My mood is more stable. Even my relationships have improved because I'm more present and engaged,\" he shares. \"I went from feeling like a victim of my diagnosis to feeling empowered by the positive changes I was making.\"\n\nJohn also discovered an unexpected passion for cooking. \"Learning to prepare healthy meals that actually taste good became a creative outlet. Now my wife and I cook together several nights a week, trying new recipes that support our health goals.\"\n\nPaying It Forward\nToday, at 50, John maintains a healthy weight of 195 pounds and normal blood glucose levels. He strength trains four times weekly, practices yoga, and enjoys hiking – activities he couldn't have imagined five years ago.\n\nInspired by his own transformation, John started a support group for others with Type 2 diabetes in his community. The group meets monthly to share resources, recipes, and encouragement.\n\n\"The diagnosis I once feared has become the catalyst for the healthiest, most fulfilling chapter of my life,\" John reflects. \"I want others to know that it's never too late to reclaim your health, and that small, consistent changes can lead to remarkable results.\"\n\nJohn's Keys to Success:\n\n1. Start with changes small enough to maintain consistently\n2. Focus on progress, not perfection\n3. Find physical activities you genuinely enjoy\n4. Develop a sustainable nutrition approach rather than a temporary diet\n5. Connect with supportive people who encourage your health goals\n6. Work with healthcare professionals who can provide personalized guidance\n7. Celebrate non-scale victories like improved energy and mood\n8. Use health metrics as feedback, not judgment\n\n\"The journey hasn't always been linear,\" John acknowledges. \"There have been setbacks and plateaus. But learning to navigate those challenges rather than being derailed by them has been crucial to long-term success.\"",
                Author = "Emma Richards",
                PublishedDate = DateTime.Now.AddDays(-22),
                ImageUrl = "/images/john-success-story.jpg",
                Category = "Success Stories",
                Tags = new List<string> { "Success Story", "Diabetes", "Weight Loss", "Health Transformation" },
                ViewCount = 2250
            },
            new BlogPost
            {
                Id = 10,
                Title = "The Mental Game: Psychological Strategies for Fitness Success",
                Excerpt = "Discover powerful mental techniques that can help you stay consistent, overcome plateaus, and achieve your fitness goals.",
                Content = "While most fitness content focuses on sets, reps, and macronutrients, the psychological aspects of fitness often determine who succeeds and who struggles. This article explores evidence-based mental strategies that can transform your fitness journey.\n\nThe Mind-Body Connection\nYour thoughts and beliefs about exercise significantly impact your physiological responses. Research has shown that people who view physical activity positively experience better outcomes than those who see it as punishment or obligation. This mind-body connection influences everything from hormone release to perceived exertion during workouts.\n\nReframing Exercise\nThe first step in improving your mental approach is to reframe how you think about exercise. Instead of \"I have to work out today,\" try \"I get to move my body today.\" This subtle shift from obligation to opportunity can transform your motivation and enjoyment.\n\nPractical exercise: For one week, before each workout, write down one thing you appreciate about being able to exercise. This might be gratitude for your body's capabilities, the stress relief exercise provides, or the community at your gym.\n\nImplementing Implementation Intentions\nOne of the most powerful psychological techniques for behavior change is creating implementation intentions – specific plans that link situations to actions. Rather than a vague goal like \"I'll exercise more,\" you create an if-then plan: \"If it's Monday, Wednesday, or Friday at 7am, then I'll do my strength workout.\"\n\nResearch shows that implementation intentions can double or triple the likelihood of performing the intended behavior because they eliminate the decision-making process when willpower might be low.\n\nPractical exercise: Create three specific implementation intentions for your fitness routine, identifying the exact day, time, and activity. Place these somewhere visible as reminders.\n\nHarnessing Visualization\nElite athletes have long used visualization techniques to enhance performance, and research confirms its effectiveness for exercisers at all levels. Regularly visualizing yourself completing workouts, overcoming challenges, and achieving your goals creates neural patterns similar to actually performing the activities.\n\nFor maximum benefit, make your visualizations as detailed as possible, incorporating all senses. Imagine the feel of the weights in your hands, the sound of your breathing, and the satisfaction of completing your workout.\n\nPractical exercise: Spend 5 minutes before bed visualizing your next workout in detail, imagining yourself performing each exercise with perfect form and feeling strong and capable.\n\nDeveloping a Growth Mindset\nPsychologist Carol Dweck's research on mindset shows that people with a \"growth mindset\" (believing abilities can be developed through dedication and hard work) achieve more than those with a \"fixed mindset\" (believing abilities are innate and unchangeable).\n\nIn fitness, a growth mindset helps you view challenges and setbacks as opportunities to improve rather than evidence of limitation. When you fail to complete a workout or reach a goal, you see it as a temporary situation that provides valuable feedback.\n\nPractical exercise: When facing a fitness challenge, ask yourself: \"What can I learn from this?\" and \"How can this help me improve?\" rather than \"Why can't I do this?\"\n\nUsing Temptation Bundling\nBehavioral economist Katherine Milkman developed the concept of \"temptation bundling\" – pairing an activity you should do with one you want to do. For fitness, this might mean only listening to your favorite podcast while walking or only watching certain TV shows while on the treadmill.\n\nThis strategy leverages immediate rewards to help maintain behaviors that have delayed benefits, making it easier to stay consistent with your fitness routine.\n\nPractical exercise: Identify one \"want\" activity you can pair exclusively with a \"should\" fitness activity, and commit to this pairing for two weeks.\n\nPracticing Self-Compassion\nResearch by Dr. Kristin Neff shows that self-compassion – treating yourself with the same kindness you would offer a good friend – leads to better outcomes than self-criticism. In fitness, this means acknowledging when you're struggling without harsh judgment and recognizing that setbacks are part of everyone's journey.\n\nContrary to common belief, self-compassion doesn't lead to complacency; it actually improves resilience and the ability to bounce back from failures.\n\nPractical exercise: After a missed workout or dietary slip, write down what you would say to a friend in the same situation, then direct those same compassionate words to yourself.\n\nBuilding Identity-Based Habits\nJames Clear, author of \"Atomic Habits,\" emphasizes that the most powerful behavior changes occur when they connect to your identity. Rather than focusing solely on outcome goals (\"I want to lose 20 pounds\"), focus on identity goals (\"I am becoming someone who prioritizes health\").\n\nAsk yourself: \"What would a healthy person do?\" When faced with choices about exercise or nutrition. This identity-focused approach creates lasting change because you're acting in alignment with your self-image.\n\nPractical exercise: Complete the sentence \"I am someone who...\" with three fitness-related identity statements. Review these daily to reinforce your evolving self-concept.\n\nIntegrating Mental Training\nJust as physical training requires consistency, these psychological strategies need regular practice to be effective. Consider dedicating 5-10 minutes daily to mental training through visualization, affirmations, or mindfulness practices specifically related to your fitness goals.\n\nRemember that the mind and body work as an integrated system. By strengthening your mental approach to fitness, you enhance your physical results and create a more sustainable, enjoyable fitness journey.",
                Author = "Dr. Rebecca Chen",
                PublishedDate = DateTime.Now.AddDays(-3),
                ImageUrl = "/images/mental-fitness.jpg",
                Category = "Motivation",
                Tags = new List<string> { "Psychology", "Motivation", "Mindset", "Habits" },
                ViewCount = 1560
            }
        };

        // GET: Blog - Shows list of all blog posts
        public IActionResult Index()
        {
            // Track page view for analytics (in a real app)
            // _analyticsService.TrackPageView("Blog Index");

            return View(_blogPosts);
        }

        // GET: Blog/Detail/5 - Shows a specific blog post
        public IActionResult Detail(int id)
        {
            var post = _blogPosts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            // Increment view count (in a real app, you'd want to prevent duplicate counts)
            post.ViewCount++;

            // Get related posts (same category, excluding current post)
            var relatedPosts = _blogPosts
                .Where(p => p.Category == post.Category && p.Id != post.Id)
                .Take(3)
                .ToList();

            ViewBag.RelatedPosts = relatedPosts;

            return View(post);
        }

        // GET: Blog/Category/Nutrition - Shows posts filtered by category
        public IActionResult Category(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return RedirectToAction("Index");
            }

            var posts = _blogPosts
                .Where(p => p.Category != null && p.Category.ToLower() == category.ToLower())
                .ToList();

            ViewBag.CategoryName = category;
            return View("CategoryPosts", posts);
        }

        // GET: Blog/Search?query=protein - Search functionality
        public IActionResult Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return RedirectToAction("Index");
            }

            var searchResults = _blogPosts
                .Where(p =>
                    (p.Title != null && p.Title.Contains(query, StringComparison.OrdinalIgnoreCase)) ||
                    (p.Content != null && p.Content.Contains(query, StringComparison.OrdinalIgnoreCase)) ||
                    (p.Tags != null && p.Tags.Any(t => t != null && t.Contains(query, StringComparison.OrdinalIgnoreCase))))
                .ToList();

            ViewBag.SearchQuery = query;
            return View("Featured", searchResults); // Using Featured view instead of SearchResults
        }

        // GET: Blog/Featured - Shows featured blog posts
        public IActionResult Featured()
        {
            // You can customize this to show specific featured posts based on criteria
            // For example, sort by view count, date, or manually selected featured posts

            // Here we're sorting by view count to show most popular posts first
            var featuredPosts = _blogPosts
                .OrderByDescending(p => p.ViewCount)
                .ToList();

            return View(featuredPosts);
        }

        // GET: Blog/Author/John%20Smith - Shows posts by a specific author
        public IActionResult Author(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return RedirectToAction("Index");
            }

            var authorPosts = _blogPosts
                .Where(p => p.Author != null && p.Author.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            ViewBag.AuthorName = name;
            return View("AuthorPosts", authorPosts);
        }

        // GET: Blog/Tag/Nutrition - Shows posts with a specific tag
        public IActionResult Tag(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag))
            {
                return RedirectToAction("Index");
            }

            var taggedPosts = _blogPosts
                .Where(p => p.Tags != null && p.Tags.Any(t => t != null && t.Contains(tag, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            ViewBag.TagName = tag;
            return View("TagPosts", taggedPosts);
        }

        // GET: Blog/Archive/2023/05 - Shows posts from a specific month and year
        public IActionResult Archive(int year, int month)
        {
            var archivedPosts = _blogPosts
                .Where(p => p.PublishedDate.Year == year && p.PublishedDate.Month == month)
                .ToList();

            ViewBag.ArchiveYear = year;
            ViewBag.ArchiveMonth = month;
            ViewBag.ArchiveMonthName = new DateTime(year, month, 1).ToString("MMMM");

            return View("ArchivePosts", archivedPosts);
        }
    }
}