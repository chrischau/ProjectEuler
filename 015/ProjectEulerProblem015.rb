require 'matrix'

@startTime = Time.now
@dimension = 21

class Matrix
  def []=(row, column, value)
    @rows[row][column] = value
  end
end

matrix = Matrix.build(@dimension, @dimension) { 1 }

for x in 1..@dimension-1
  for y in 1..@dimension-1
    matrix[x, y] = matrix[x-1, y] + matrix[x, y-1]
  end
end

puts matrix[@dimension-1, @dimension-1]

puts "Time took: " + (Time.now - @startTime).to_s + " seconds"