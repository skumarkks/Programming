#Algoexpert: tournament Winner
class Solution:
    def findwinner(self, competitions:list, results: list, point:int):
        bestteam = ""
        scores = {bestteam : 0}

        for idx, competition in enumerate(competitions):
            result = results[idx]
            hometeam, awayteam = competition

            if result == 0:
                self.updatescore(scores, awayteam, point)
                if scores[bestteam] < scores[awayteam]:
                    bestteam = awayteam
            else:
                self.updatescore(scores, hometeam, point)
                if scores[bestteam] < scores[hometeam]:
                    bestteam = hometeam
        return bestteam

    def updatescore(self, scores, team, point):
        if team not in scores:
            scores[team] = 0
        scores[team] += point



sol = Solution()
competitions = [["HTML", "C#"],
                ["C#", "Python"],
                ["Python","C#"]
               ]
result = [0, 1, 0]

winner = sol.findwinner(competitions, result, 3)
print(winner)



competitions = [
    ["HTML", "Java"],
    ["Java", "Python"],
    ["Python", "HTML"],
    ["C#", "Python"],
    ["Java", "C#"],
    ["C#", "HTML"]
  ]
results = [0, 1, 1, 1, 0, 1]
sol = Solution()
winner = sol.findwinner(competitions, results, 3)
print(winner)


