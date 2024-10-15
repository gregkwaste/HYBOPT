﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gurobi;

namespace CHRVRP
{
    class Solver
    {
        public static GRBEnv gurobiEnv = new GRBEnv();

        public static bool IsEqual(double a, double b, double prec)
        {
            return Math.Abs(a - b) > prec ? false : true;
        }

        /*
         * TODO: lefmanou
         */
        public static void OptimizeRelaxedSupplyAndCustomerAssignmentModel(Solution sol, int maxInsDel, double minSpChange)
        {
            Relaxations.SolveRelaxedSupplyAndCustomerAssignmentModel(sol, maxInsDel, minSpChange);
        }

        /*
         * Classic TSP with callbacks implementation. Fixed sets and nodes, optimize orders http://webhotel4.ruc.dk/~keld/research/LKH/
         */
        //public static void SolveTSP(Model m, Solution sol, double secLimit = 2, double mipGapLimit = 1e-4, double heur = 0.5, bool hide_errors = false)
        //{
        //    // Gurobi default double secLimit = 1e+100, double mipGapLimit = 1e-4, double heur = 0.05
        //    if (sol.route.nodes_seq.Count > 4)
        //    {
        //        //Solution copysol = sol.ShallowCopy(m);

        //        //var watch = System.Diagnostics.Stopwatch.StartNew();
        //        // LKH is an effective implementation of the Lin-Kernighan heuristic for solving the traveling salesman problem.
        //        TSP.LKHAlgorithm(m, sol, hide_errors: hide_errors);
        //        //watch.Stop();
        //        //var elapsedMs = watch.ElapsedMilliseconds;
        //        //sConsole.WriteLine("LKH: " +  elapsedMs + " ms");

        //        /*
        //        var watch2 = System.Diagnostics.Stopwatch.StartNew();
        //        // Gurobi MIP
        //        TSP.FixedNodesTSP(m, copysol, secLimit, mipGapLimit, heur);
        //        watch2.Stop();
        //        var elapsedMs2 = watch2.ElapsedMilliseconds;
        //        Console.WriteLine("GRB :" + elapsedMs2 + " ms");
        //        */
        //    }
        //}
    }
}
