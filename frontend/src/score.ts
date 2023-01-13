import type Category from "./types/category";

export function getGroupScore(categories: Category[]) {
  let score = 0;
  for (const category of categories) {
    const times = [
      category.times.walking,
      category.times.cycling,
      category.times.publicTransport,
    ];
    const bestTime = Math.min(...times);
    let tempScore = 1.0 - Math.max(bestTime - 15, 0) / 15;
    for (const time of times) {
      if (time <= 20) tempScore += 0.1;
    }
    tempScore = Math.min(tempScore, 1);
    score += tempScore;
  }

  score /= categories.length;
  score = Math.min(score, 1);
  return score;
}
