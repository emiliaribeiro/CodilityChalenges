using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private PokerChips pokerChips;
        //private WeddingList weddingList;
        //private TopMostRepeatedChar topMostRepeatedChar;
        //private BalancedBrackets balancedBrackets;
        //private CyclicRotation cyclicRotation;
        //private OddOccurrencesInArray oddOccurrencesInArray;
        //private BinaryGap binaryGap;
        //private Frog frog;
        //private FrogRiver frogRiver;
        //private PermMissingElem permMissingElem;
        //private TapeEquilibrum tapeEquilibrum;
        //private MaxCounters maxCounters;
        //private SamallestMissingInteger samallestMissingInteger;
        //private PermCheck permCheck;
        //private CountDiv count;
        //private PassingCars passingCars;
        //GenomicRangeQuery genomicRangeQuery;
        //private Dictionary<int, int> pokerChipValues = new Dictionary<int, int>();
        private string text = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            //pokerChips = new PokerChips();
            //weddingList = new WeddingList();
            //topMostRepeatedChar = new TopMostRepeatedChar();
            //binaryGap = new BinaryGap();
            //balancedBrackets = new BalancedBrackets();
            //cyclicRotation = new CyclicRotation();
            //oddOccurrencesInArray = new OddOccurrencesInArray();
            //permMissingElem = new PermMissingElem();
            //tapeEquilibrum = new TapeEquilibrum();
            //frog = new Frog();
            //frogRiver = new FrogRiver();
            //maxCounters = new MaxCounters();
            //samallestMissingInteger = new SamallestMissingInteger();
            //permCheck = new PermCheck();
            //count = new CountDiv();
            //passingCars = new PassingCars();
            //genomicRangeQuery = new GenomicRangeQuery();

            //MaxDoubleSliceSum sum = new MaxDoubleSliceSum();

            //MaxCounters maxCounters = new MaxCounters();

            //DivisoresDeN divisoresDeN = new DivisoresDeN();

            //ReverseCoins reverseCoins = new ReverseCoins();
            InitializeLabel();
        }

        private void InitializeLabel()
        {
            //pokerChipValues = this.pokerChips.GetValues();

            //foreach(KeyValuePair<int, int>  kvp in pokerChipValues)
            //{
            //    text += "Chip" + kvp.Key +"Quantity" + kvp.Value +"\n";
            //}

            //wedding
            //text += weddingList.AreListsEquals().ToString();

            //MostRepeated
            //foreach(char car in topMostRepeatedChar.MostRepeatedChar())
            //{
            //    text += car + "\n";
            //}

            //text = balancedBrackets.IsBalanced().ToString();

            //BinaryGap
            //text = binaryGap.Count().ToString();

            //int[] A = new int[] { 3, 8, 9, 7, 6 };
            //int[] Aux = cyclicRotation.solution(A, 3);


            //int[] A = new int[] { };
            //int[] Aux = cyclicRotation.solution(A, 5);

            //foreach (int number in Aux)
            //{
            //    text += number + ",";
            //}

            //int[] A = new int[] {9, 3, 9, 3, 9, 7,7,7, 9 };
            //text = oddOccurrencesInArray.solution(A).ToString();

            //text = frog.solution(30, 30, 90).ToString();

            //Missing Element
            //int[] A = new int[] { 1,2 ,3 ,4, 5 ,6,7, 9, 8, 10, 11, 12, 17, 18, 16, 19, 14, 15 };
            //int[] A = new int[] { 7, 8 };
            //text = permMissingElem.solution(A).ToString();

            //tapeEquilibrum
            //int[] A = new int[] { -1000, 1000};
            //text = tapeEquilibrum.solution(A).ToString();

            //FrogRiver
            //int[] A = new int[] {1,3,1,4,2,3,5,4};
            //text = frogRiver.solution(5, A).ToString();

            //MaxCounter
            //int[] A = new int[] {3, 4, 4, 6, 1, 4, 4 };
            ////int[] A = new int[] { };
            //int[] solution = maxCounters.solution(5, A);
            //foreach(int i in solution)
            //{
            //    text += i + ",";
            //}

            //int[] A = new int[] {2,3};
            //string text = samallestMissingInteger.solution(A).ToString();

            //int[] A = new int[] { 1,3,2,4 };
            //text = permCheck.solution(A).ToString();
            //int B = int.MaxValue;

            //text = count.solution(0,0,11).ToString();

            //PassingCars
            //int[] A = new int[] { 0,0,0,0};
            //text = passingCars.solution(A).ToString();

            //genomicRangeQuery
            //string S = "GGGGGGGGG";
            //int[] P = new int[] {0,0,1 };
            //int[] Q = new int[] {0,1,1 };
            //foreach (int i in genomicRangeQuery.solution(S, P, Q))
            //{
            //    text += i + ",";
            //}

            //MinAVGToSlice minAVGToSlice = new MinAVGToSlice();
            //int[] A = new int[] { 4, 2,2,5,1,5,8};
            //text = minAVGToSlice.solution(A).ToString();

            //Distinct distinct = new Distinct();
            //int[] A = new int[] {  };

            // TripletSum
            //Triplet triplet = new Triplet();
            //int[] A = new int[] { -3, 1, 2, -2, 5, 6 };
            //int[] A = new int[] { };
            ////text = triplet.sum(A).ToString();
            //text = triplet.Product2(A).ToString();

            //Triangle triangle = new Triangle();
            //int[] A = new int[] {10,2,5,1,8,20 };
            //text = triangle.solution(A).ToString();

            //Dominator dominator = new Dominator();
            //int[] A = new int[] { 2 };
            //text = dominator.solution(A).ToString();

            //Equileader equileader = new Equileader();
            //int[] A = new int[] { 4, 3,4,4,4,2 };
            //equileader.solution(A);

            //MaxSlice maxSlice = new MaxSlice();

            //int[] A = new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };
            //text = maxSlice.solutionProfitB(A).ToString();

            //MaxDoubleSliceSum maxDoubleSliceSum = new MaxDoubleSliceSum();
            //int[] A = new int[] { 3, 2, 6, -1, 4, 5, -1, 2 };
            //text = maxDoubleSliceSum.solution(A).ToString();

            //Primes primes = new Primes();
            //primes.primesNumbers(10);

            //CountFactors countFactors = new CountFactors();
            //text = countFactors.solutionB(30).ToString();
            //Peaks peaks = new Peaks();
            //int[] A = new int[] {1,2,3,4,3,4,1,2,3,4,6,2 };
            ////int[] A = new int[] { 1,2 };
            ////int[] A = new int[] { 0, 1, 0, 0, 1, 0, 0, 1, 0};
            //peaks.solution(A);

            //ChocolatesByNumbers chocolatesByNumbers = new ChocolatesByNumbers();
            //chocolatesByNumbers.solutionB(1, 10);
            ////MMC mMC = new MMC();
            ////mMC.mmc(3,2);

            //CommonPrimeDivisors commonPrimeDivisors = new CommonPrimeDivisors();
            //int[] A = new int[] { 2, 1, 2 };
            //int[] B = new int[] { 1, 2, 2 };
            //commonPrimeDivisors.solutionB(A, B);

            //ErastotenesPrimos erastotenesPrimos = new ErastotenesPrimos();
            //erastotenesPrimos.simpleSieve(50);
            //int[] A = new int[] { 3 };

            //CountNonDivisible countNonDivisible = new CountNonDivisible();
            //countNonDivisible.solution(A);

            //DecomposicaoPrimos decomposicaoPrimos = new DecomposicaoPrimos();
            //decomposicaoPrimos.solution(48);

            //CountSemiprimes countSemiprimes = new CountSemiprimes();
            //int[] A = new int[] { 1, 4, 16};
            //int[] B = new int[] { 26, 10, 20 };
            //countSemiprimes.solution(26, A, B);

            //FibonnacciSequence fibonnacciSequence = new FibonnacciSequence();
            //fibonnacciSequence.Sequence2(12);

            //SubsequenceEqualsSum subsequenceEqualsSum = new SubsequenceEqualsSum();
            //int[] A = new int[] {1,2,1,6};
            //subsequenceEqualsSum.SubSum(A, 6);

            //AbsDistinct absDistinct = new AbsDistinct();
            //int[] A = new int[] { -2147483648, 1, 2, 2147483647 };
            //absDistinct.solution(A);

            //CountDistinctSlices countDistinctSlices = new CountDistinctSlices();
            //int[] A = new int[] { 1,1,1,1,2,3,1,2,3,4};
            //countDistinctSlices.solution(6, A);


            //TriangularTriplet triangularTriplet = new TriangularTriplet();
            //int[] A = new int[] { 10,2,5,1,8,12};
            //triangularTriplet.solutionB(A);

            //BalancedBrackets balancedBrackets = new BalancedBrackets();
            //FishQueues fishQueues = new FishQueues();

            //////MissingInteger missingInteger = new MissingInteger();
            //PermMissingElem permMissingElem = new PermMissingElem();

            //Dominator dominator = new Dominator();

            //Equileader equileader = new Equileader();
            //BinarySearch binarySearch = new BinarySearch();

            //NailingPlanks nailingPlanks = new NailingPlanks();
            //NumberOfDiscIntersections numberOfDiscIntersections = new NumberOfDiscIntersections();  

            //MaxSlice maxSlice = new MaxSlice();

            //Peaks peaks = new Peaks();
            //MinMaxDivision minMaxDivision = new MinMaxDivision();


            //NailingPlanks nailingPlanks = new NailingPlanks();

            //LongestPassword longestPassword = new LongestPassword();        
            //StrSymmetryPoint strSymmetryPoint = new StrSymmetryPoint();
            //ArrayInversionCount arrayInversionCount = new ArrayInversionCount();
            //TapeEquilibrum tapeEquilibrum = new TapeEquilibrum();
            //FrogRiver frogRiver = new FrogRiver();

            //MaxProductOfThree max = new MaxProductOfThree();

            //RectangleBuilderGreaterArea rectangleBuilderGreaterArea = new RectangleBuilderGreaterArea();

            //TennisTournament tennisTournament = new TennisTournament();
            //this.Label.Content = text;


            //Task1 task1 = new Task1();

            //PairsSocks pairsSocks = new PairsSocks();

            //CountingValeys countingValeys = new CountingValeys();

            //JumpClouds jumpClouds = new JumpClouds();

            Repeated_String repeated_String = new Repeated_String();

        }
    }
}
