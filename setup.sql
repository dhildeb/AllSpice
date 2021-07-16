CREATE TABLE recipe(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  title VARCHAR(255),
  description VARCHAR(255),
  imgUrl VARCHAR(255),
  creator VARCHAR(255),
  creatorId INT
);
CREATE TABLE ingredients(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255),
  quantity INT,
  recipeId INT
);
CREATE TABLE steps(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  step VARCHAR(255),
  index int
);