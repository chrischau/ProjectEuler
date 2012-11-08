startTime = Time.now
sum = 1

def divideByOneToTwenty(number)
  for counter in 2..20
    if (number % counter != 0)
      return false
    end
  end
  
  return true
end

for counter in 2520..1000000000    
  if (divideByOneToTwenty(counter))
    sum = counter
    break
  end
end


puts "Smallest Number divisible by 1 through 20: " + (sum).to_s
puts "Time took: " + (Time.now - startTime).to_s + " seconds"