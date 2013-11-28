@startTime = Time.now
@sum = 0
@maxNumber = 100000

for number in (1..@maxNumber)
  @divisorCounter = 0
  @sum += number

  #puts @sum
  @max = @sum

  for i in 1..@max
    if (i >= @max)
      break
    end
  
    if (@sum % i == 0)
      (@sum == i) ? @divisorCounter += 1 : @divisorCounter += 2
      @max = @sum / i          
    end  
  end
  
  if (@divisorCounter > 500)
    puts "the first triangle number to have over five hundred divisors is " + @sum.to_s + " at iteration " + number.to_s
    break
  end
  
  puts @sum.to_s + " : " + @divisorCounter.to_s
end

puts "Time took: " + (Time.now - @startTime).to_s + " seconds"