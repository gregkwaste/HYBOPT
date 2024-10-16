import random, ReadData
import Classes
from matplotlib import pyplot as plt

def visualize(m):
    # specify the name of the report_sol file generated by the Report_Sol method of class Solution
    filename = "217vm1084_T40_p1.txt"

    random.seed(1)
    m = ReadData.importModel(filename)
    sets_included = [m.allSets[m.allNodes[i].set_id] for i in m.path[1:]]
    print(m.node_crowd, m.set_crowd, len(sets_included))

    plt.scatter(m.allNodes[0].x, m.allNodes[0].y, color="black")
    for set in m.allSets[1:]:
        color = (random.random(), random.random(), random.random())
        x_points = [n.x for n in set.nodes]
        y_points = [n.y for n in set.nodes]
        if set in sets_included:
            plt.scatter(x_points, y_points, color=color)
        else:
            plt.scatter(x_points, y_points, marker='x', color=color)
    path_x = [m.allNodes[i].x for i in m.path]
    path_y = [m.allNodes[i].y for i in m.path]
    plt.plot(path_x, path_y, linewidth=1)
    plt.xlim(0, 20000)
    plt.ylim(3500, 13000)
    plt.savefig(m.dataset + "_adjusted_axis.png")
    plt.close()

def visualizeTSP(m):

    for node in m.allNodes:
        plt.scatter(node.x, node.y, color="blue")

    plt.scatter(m.allNodes[0].x, m.allNodes[0].y, color="black")

    plt.xlim(0, 20000)
    plt.ylim(3500, 13000)
    plt.savefig(m.dataset + "_adjusted_axis.png")
    plt.close()

def visualizeSOP(m):
    random.seed(1)

    plt.scatter(m.allNodes[0].x, m.allNodes[0].y, color="black")
    for set in m.allSets[1:]:
        color = (random.random(), random.random(), random.random())
        x_points = [n.x for n in set.nodes]
        y_points = [n.y for n in set.nodes]
        plt.scatter(x_points, y_points, color=color)
    #plt.xlim(0, 20000)
    #plt.ylim(3500, 13000)
    plt.savefig(m.name + ".png")
    plt.show
    plt.close()
