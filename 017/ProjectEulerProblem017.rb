@startTime = Time.now

def NumberToEnglishMapping(value)
  case
    when value == 1 
      "One"
    when value == 2 
      "Two"
    when value == 3 
      "Three"
    when value == 4 
      "Four"
    when value == 5 
      "Five"
    when value == 6 
      "Six"
    when value == 7 
      "Seven"
    when value == 8 
      "Eight"
    when value == 9 
      "Nine"
    when value == 10 
      "Ten"
    when value == 11 
      "Eleven"
    when value == 12 
      "Twelve"
    when value == 13 
      "Thirteen"
    when value == 14 
      "Fourteen"
    when value == 15 
      "Fifteen"
    when value == 16 
      "Sixteen"
    when value == 17 
      "Seventeen"
    when value == 18 
      "Eighteen"
    when value == 19 
      "Nineteen"
    when value == 20 
      "Twenty"
    when value == 30 
      "Thirty"
    when value == 40 
      "Forty"
    when value == 50 
      "Fifty"
    when value == 60 
      "Sixty"
    when value == 70 
      "Seventy"
    when value == 80 
      "Eighty"
    when value == 90 
      "Ninety"
    else
      ""
  end
end

def TranslateNumberUnderAHundredToEnglish(value)
  if (value > 20)
    return NumberToEnglishMapping(value / 10 * 10) + NumberToEnglishMapping(value % 10)
  else
    return NumberToEnglishMapping(value)
  end  
end

def FindSumOfLetters(value)
  @sum = 0
  
  for number in 1..value
    @translatedEnglish = ""
    
    if (number == 1000)
      @translatedEnglish = "OneThousand"  
    elsif (number >= 100)
      @translatedEnglish = "#{NumberToEnglishMapping(number / 100)}Hundred"
      
      if (number % 100 != 0)
        @translatedEnglish += "And#{ TranslateNumberUnderAHundredToEnglish(number % 100)}"
      end      
    else
      @translatedEnglish += "#{ TranslateNumberUnderAHundredToEnglish(number % 100)}"        
    end
    
    #puts @translatedEnglish.to_s
    
    @sum += @translatedEnglish.to_s.length
  end
  
  return @sum
end

puts "the numbers from 1 to 1000 (one thousand) is #{ FindSumOfLetters(1000).to_s }"

puts "Time took: " + (Time.now - @startTime).to_s + " seconds"
