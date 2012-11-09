startTime = Time.now

def isPythagoreanTriplet(a, b, c)
  return a*a + b*b == c*c
end

largestSum = 0

for a in 1..500
  for b in 1..499
    c = 1000 - b - a
    
    if (isPythagoreanTriplet(a, b, c))
      puts a.to_s + "2 + " + b.to_s + "2 = " + c.to_s + "2"
      puts a * b * c
    end
  end
end

puts "Time took: " + (Time.now - startTime).to_s + " seconds"