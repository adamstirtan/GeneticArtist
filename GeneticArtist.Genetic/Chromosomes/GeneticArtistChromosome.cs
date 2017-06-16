using AForge.Genetic;
using AForge.Math.Random;

namespace GeneticArtist.Genetic.Chromosomes
{
    public sealed class GeneticArtistChromosome : DoubleArrayChromosome
    {
        public GeneticArtistChromosome(
            IRandomNumberGenerator chromosomeGenerator,
            IRandomNumberGenerator mutationMultiplierGenerator,
            IRandomNumberGenerator mutationAdditionGenerator,
            int length)
            : base(chromosomeGenerator, mutationMultiplierGenerator, mutationAdditionGenerator, length)
        { }

        public GeneticArtistChromosome(
            IRandomNumberGenerator chromosomeGenerator,
            IRandomNumberGenerator mutationMultiplierGenerator,
            IRandomNumberGenerator mutationAdditionGenerator,
            double[] values)
            : base(chromosomeGenerator, mutationMultiplierGenerator, mutationAdditionGenerator, values)
        { }

        public GeneticArtistChromosome(DoubleArrayChromosome source)
            : base(source)
        { }
    }
}
