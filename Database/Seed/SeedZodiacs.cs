using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Seed
{
    public class Seed
    {
        public static void SeedZodiacs(ZodiacContext context)
        {
            if (context.Zodiacs.Any())
                return;

            var zodiacs = new List<Zodiac>
            {
                new Zodiac
                {
                    ZodiacSign = "Aries",
                    FromDate = new DateOnly(1970, 3, 21),
                    ToDate = new DateOnly(1970, 4, 19)
                },new Zodiac
                {
                    ZodiacSign = "Taurus",
                    FromDate = new DateOnly(1970, 4, 20),
                    ToDate = new DateOnly(1970, 5, 20)
                },new Zodiac
                {
                    ZodiacSign = "Gemini",
                    FromDate = new DateOnly(1970, 5, 21),
                    ToDate = new DateOnly(1970, 6, 21)
                },new Zodiac
                {
                    ZodiacSign = "Cancer",
                    FromDate = new DateOnly(1970, 6, 22),
                    ToDate = new DateOnly(1970, 7, 22)
                },new Zodiac
                {
                    ZodiacSign = "Leo",
                    FromDate = new DateOnly(1970, 7, 23),
                    ToDate = new DateOnly(1970, 8, 22)
                },new Zodiac
                {
                    ZodiacSign = "Virgo",
                    FromDate = new DateOnly(1970, 8, 23),
                    ToDate = new DateOnly(1970, 9, 22)
                },new Zodiac
                {
                    ZodiacSign = "Libra",
                    FromDate = new DateOnly(1970, 9, 23),
                    ToDate = new DateOnly(1970, 10, 23)
                },new Zodiac
                {
                    ZodiacSign = "Scorpius",
                    FromDate = new DateOnly(1970, 10, 24),
                    ToDate = new DateOnly(1970, 11, 21)
                },new Zodiac
                {
                    ZodiacSign = "Sagittarius",
                    FromDate = new DateOnly(1970, 11, 22),
                    ToDate = new DateOnly(1970, 12, 21)
                },new Zodiac
                {
                    ZodiacSign = "Capricornus",
                    FromDate = new DateOnly(1970, 12, 22),
                    ToDate = new DateOnly(1971, 1, 19)
                },new Zodiac
                {
                    ZodiacSign = "Aquarius",
                    FromDate = new DateOnly(1970, 1, 20),
                    ToDate = new DateOnly(1970, 2, 18)
                },new Zodiac
                {
                    ZodiacSign = "Pisces",
                    FromDate = new DateOnly(1970, 2, 19),
                    ToDate = new DateOnly(1970, 3, 20)
                },
            };

            context.Zodiacs.AddRange(zodiacs);
            context.SaveChanges();
        }
        public static void SeedCompatibleZodiacs(ZodiacContext context)
        {
            if (context.CompatibleZodiacs.Any())
                return;

            var compatibleZodiacs = new List<CompatibleZodiacs>
            {
                new CompatibleZodiacs
                {
                    ZodiacId = 1,
                    CompatibleZodiacId = 3
                },new CompatibleZodiacs
                {
                    ZodiacId = 1,
                    CompatibleZodiacId = 11
                },new CompatibleZodiacs
                {
                    ZodiacId = 2,
                    CompatibleZodiacId = 4
                },new CompatibleZodiacs
                {
                    ZodiacId = 2,
                    CompatibleZodiacId = 12
                },new CompatibleZodiacs
                {
                    ZodiacId = 3,
                    CompatibleZodiacId = 1
                },new CompatibleZodiacs
                {
                    ZodiacId = 3,
                    CompatibleZodiacId = 5
                },new CompatibleZodiacs
                {
                    ZodiacId = 5,
                    CompatibleZodiacId = 3
                },new CompatibleZodiacs
                {
                    ZodiacId = 5,
                    CompatibleZodiacId = 7
                },new CompatibleZodiacs
                {
                    ZodiacId = 6,
                    CompatibleZodiacId = 4
                },new CompatibleZodiacs
                {
                    ZodiacId = 6,
                    CompatibleZodiacId = 8
                },new CompatibleZodiacs
                {
                    ZodiacId = 7,
                    CompatibleZodiacId = 5
                },new CompatibleZodiacs
                {
                    ZodiacId = 7,
                    CompatibleZodiacId = 9
                },new CompatibleZodiacs
                {
                    ZodiacId = 8,
                    CompatibleZodiacId = 6
                },new CompatibleZodiacs
                {
                    ZodiacId = 8,
                    CompatibleZodiacId = 10
                },new CompatibleZodiacs
                {
                    ZodiacId = 9,
                    CompatibleZodiacId = 7
                },new CompatibleZodiacs
                {
                    ZodiacId = 9,
                    CompatibleZodiacId = 11
                },new CompatibleZodiacs
                {
                    ZodiacId = 10,
                    CompatibleZodiacId = 8
                },new CompatibleZodiacs
                {
                    ZodiacId = 10,
                    CompatibleZodiacId = 12
                },new CompatibleZodiacs
                {
                    ZodiacId = 11,
                    CompatibleZodiacId = 2
                },new CompatibleZodiacs
                {
                    ZodiacId = 11,
                    CompatibleZodiacId = 9
                },new CompatibleZodiacs
                {
                    ZodiacId = 12,
                    CompatibleZodiacId = 2
                },new CompatibleZodiacs
                {
                    ZodiacId = 12,
                    CompatibleZodiacId = 10
                },
            };

            context.CompatibleZodiacs.AddRange(compatibleZodiacs);
            context.SaveChanges();
        }
    }
}
