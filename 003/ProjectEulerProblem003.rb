startTime = Time.now
number = 600851475143
squareRootedNumber = Math.sqrt(number)
result = 0

sift = Array.new(squareRootedNumber)
existingPrimeNumbers = Array.new()

def IsPrime(number, existingPrimeNumbers)
  existingPrimeNumbers.each do |primeNumber|
    if (number % primeNumber == 0)
      return false
    end   
  end
  
  return true
end


for counter in 2..squareRootedNumber
  if (sift[counter].nil?)
    if (IsPrime(counter, existingPrimeNumbers))
      existingPrimeNumbers.push(counter)
      
      for siftIndex in counter..squareRootedNumber
        if (sift[siftIndex].nil? and (siftIndex % counter == 0))
          sift[siftIndex] = "Not Prime"                   
        end
      end
      
      if (number % counter == 0)
        puts (counter).to_s + " and " +  (number / counter).to_s
        result = counter
      end
    end
  end
end

puts "The largest divisible prime: " + result.to_s
puts "Time took: " + (Time.now - startTime).to_s + " seconds"